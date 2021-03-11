using BusinessLogicLayer;
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

namespace WindowsFormsUI
{
    public partial class BanksForms : Form
    {
        public BanksForms()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void CompanyList()
        {
            List<Company> companyList = new List<Company>();
            companyList = new CompanyBusiness().CompanyList();
            cmdCompany.ValueMember = "FirmaID";
            cmdCompany.DisplayMember = "FirmaAd";
            cmdCompany.DataSource = companyList;
        }
        void BanksList()
        {
            List<Banks> banksList = new BanksBusiness().BanksList();
            gridBanks.DataSource = banksList;
            gridBanks.RowHeadersVisible = false;
            gridBanks.Columns[0].Visible = false;
            gridBanks.Columns[3].Width = 300;
            gridBanks.Columns[8].Width = 200;
            string[] name = { "BankaID", "Banka Adı", "Şube", "Iban", "Hesap No", "Yetkili", "Tarih", "Hesap Tür", "Firma" };
            for (int i = 0; i < name.Length; i++)
            {
                gridBanks.Columns[i].HeaderText = name[i];
            }
        }
        private void BanksForms_Load(object sender, EventArgs e)
        {
            BanksList();
            CompanyList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            BanksBusiness banksB = new BanksBusiness();
            int banksAdd = banksB.BanksAdd(txtName.Text, txtBranch.Text, txtIban.Text, txtNo.Text, txtAuthorized.Text, txtDate.Value, txtAccountType.Text, Convert.ToInt32(cmdCompany.SelectedValue));
            if (banksAdd == 0) message = "Hesap No Bilgisi Hatalı!";
            else if (banksAdd == 1) message = "Yetkili Bilgisi Hatalı!";
            else if (banksAdd == 2) message = "Banka Adı,Şube,Iban,Hesap No,Hesap Türü Boş Geçilemez!";
            else message = "Kayıt İşlemi Başarılı!";
            MessageBox.Show(message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BanksList();
            CompanyList();
        }
        int secilen;
        string id;
        private void gridBanks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = gridBanks.SelectedCells[0].RowIndex;
            id = gridBanks.Rows[secilen].Cells[0].Value.ToString();
            txtName.Text = gridBanks.Rows[secilen].Cells[1].Value.ToString();
            txtBranch.Text = gridBanks.Rows[secilen].Cells[2].Value.ToString();
            txtIban.Text = gridBanks.Rows[secilen].Cells[3].Value.ToString();
            txtNo.Text = gridBanks.Rows[secilen].Cells[4].Value.ToString();
            txtAuthorized.Text = gridBanks.Rows[secilen].Cells[5].Value.ToString();
            txtDate.Text = gridBanks.Rows[secilen].Cells[6].Value.ToString();
            txtAccountType.Text = gridBanks.Rows[secilen].Cells[7].Value.ToString();
            cmdCompany.Text = gridBanks.Rows[secilen].Cells[8].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message = "";
            if (id == null) message = "Lütfen Güncellenecek Değeri Seçin";
            else
            {
                BanksBusiness banksB = new BanksBusiness();
                int banksUpdate = banksB.BanksUpdate(short.Parse(id), txtName.Text, txtBranch.Text, txtIban.Text, txtNo.Text, txtAuthorized.Text, txtDate.Value, txtAccountType.Text, Convert.ToInt32(cmdCompany.SelectedValue));
                if (banksUpdate == 0) message = "Hesap No Bilgisi Hatalı!";
                else if (banksUpdate == 1) message = "Yetkili Bilgisi Hatalı!";
                else if (banksUpdate == 2) message = "Banka Adı,Şube,Iban,Hesap No,Hesap Türü Boş Geçilemez!";
                else message = "Güncelleme İşlemi Başarılı!";
            }          
            MessageBox.Show(message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BanksList();
            CompanyList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "";
            if (id == null) message = "Lütfen Silinecek Değeri Seçin";
            else
            {
                BanksBusiness banksB = new BanksBusiness();
                int banksDelete = banksB.BanksDelete(short.Parse(id));
                if (banksDelete == 1) message = "Kayıt silindi";
            }
            MessageBox.Show(message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BanksList();
            CompanyList();
        }
    }
}
