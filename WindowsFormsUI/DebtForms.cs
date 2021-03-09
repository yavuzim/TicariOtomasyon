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
    }
}
