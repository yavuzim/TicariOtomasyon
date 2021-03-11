using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace WindowsFormsUI
{
    public partial class DebtForms : Form
    {
        public DebtForms()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void DebtList()
        {
            List<Debt> debtList = new DebtBusiness().DebtList();
            gridDebt.DataSource = debtList;
            gridDebt.RowHeadersVisible = false;
            gridDebt.Columns[0].Visible = false;
            gridDebt.Columns[9].Width = 313;
        }
        private void DebtForms_Load(object sender, EventArgs e)
        {
            DebtList();
            string[] months = { "Ocak", "Şubat", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            cmdMonth.DataSource = months;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            DebtBusiness dB = new DebtBusiness();
            string ay = cmdMonth.Text;
            if (txtElectric.Text == "") txtElectric.Text = "0";
            if (txtWater.Text == "") txtWater.Text = "0";
            if (txtGas.Text == "") txtGas.Text = "0";
            if (txtInternet.Text == "") txtInternet.Text = "0";
            if (txtWage.Text == "") txtWage.Text = "0";
            if (txtExtra.Text == "") txtExtra.Text = "0";
            int getData = dB.DebdAdd(ay, txtYear.Text, decimal.Parse(txtElectric.Text), decimal.Parse(txtWater.Text), decimal.Parse(txtGas.Text), decimal.Parse(txtInternet.Text), decimal.Parse(txtWage.Text), decimal.Parse(txtExtra.Text), txtNote.Text);
            if (getData == 0) message = "Boş geçilmez!";
            else if (getData == 1) message = "Yıl bilgisi yanlış!!";
            else if (getData == 2) message = "Fiyatlar 0'dan küçük olamaz!";
            else message = "Kayıt Eklendi!";
            MessageBox.Show(message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DebtList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message = "";
            DebtBusiness dB = new DebtBusiness();
            string ay = cmdMonth.Text;
            if (txtElectric.Text == "") txtElectric.Text = "0";
            if (txtWater.Text == "") txtWater.Text = "0";
            if (txtGas.Text == "") txtGas.Text = "0";
            if (txtInternet.Text == "") txtInternet.Text = "0";
            if (txtWage.Text == "") txtWage.Text = "0";
            if (txtExtra.Text == "") txtExtra.Text = "0";
            int getData = dB.DebdUpdate(int.Parse(id), ay, txtYear.Text, decimal.Parse(txtElectric.Text), decimal.Parse(txtWater.Text), decimal.Parse(txtGas.Text), decimal.Parse(txtInternet.Text), decimal.Parse(txtWage.Text), decimal.Parse(txtExtra.Text), txtNote.Text);
            if (getData == 0) message = "Boş geçilmez!";
            else if (getData == 1) message = "Yıl bilgisi yanlış!!";
            else if (getData == 2) message = "Fiyatlar 0'dan küçük olamaz!";
            else message = "Güncelleme Başarılı!";
            MessageBox.Show(message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DebtList();

        }
        int secilen;
        string id;
        private void gridDebt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = gridDebt.SelectedCells[0].RowIndex;
            id = gridDebt.Rows[secilen].Cells[0].Value.ToString();
            cmdMonth.Text = gridDebt.Rows[secilen].Cells[1].Value.ToString();
            txtYear.Text = gridDebt.Rows[secilen].Cells[2].Value.ToString();
            txtElectric.Text = gridDebt.Rows[secilen].Cells[3].Value.ToString();
            txtWater.Text = gridDebt.Rows[secilen].Cells[4].Value.ToString();
            txtGas.Text = gridDebt.Rows[secilen].Cells[5].Value.ToString();
            txtInternet.Text = gridDebt.Rows[secilen].Cells[6].Value.ToString();
            txtWage.Text = gridDebt.Rows[secilen].Cells[7].Value.ToString();
            txtExtra.Text = gridDebt.Rows[secilen].Cells[8].Value.ToString();
            txtNote.Text = gridDebt.Rows[secilen].Cells[9].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id == null) MessageBox.Show("Kayıt Seçiniz!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int debtDelete = new DebtBusiness().DebdDelete(int.Parse(id));
                if (debtDelete > 0) MessageBox.Show("Kayıt Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DebtList();
        }
    }
}
