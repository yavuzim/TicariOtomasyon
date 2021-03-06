using BusinessLogicLayer;
using DatabaseLogicLayer;
using Entities;
using System;
using System.Collections;
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
    public partial class CompanyForms : Form
    {
        public CompanyForms()
        {
            InitializeComponent();
        }
        void CompanyList()
        {
            CompanyBusiness cB = new CompanyBusiness();
            List<Company> companyList = cB.CompanyList();
            gridCompany.DataSource = companyList;
            string[] columnName = { "FirmaID", "Firma Adı", "Yetkili Statü", "Yetkili Ad Soyad", "Yetkili TC", "Sektör", "Telefon 1", "Telefon 2", "Telefon 3", "E-Mail", "Fax", "Şehir", "İlçe", "Vergi Dairesi", "Adres", "Özel Kod 1", "Özel Kod 2", "Özel Kod 3" };
            for (int i = 0; i < columnName.Length; i++)
            {
                gridCompany.Columns[i].HeaderText = columnName[i];
            }
            gridCompany.RowHeadersVisible = false;
            gridCompany.Columns[0].Visible = false;
        }
        void CoreExplanation()
        {
            List<string> getCode = new CompanyBusiness().CodeExplanation();
            textCode1.Text = getCode[0].ToString();
        }
        City city = new City();
        private void CompanyForms_Load(object sender, EventArgs e)
        {
            city.GetCity(cmdCompanyCity);
            CompanyList();
        }

        private void btnCompanyrExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            CompanyBusiness cB = new CompanyBusiness();
            int getCompany = cB.CompanyAdd(txtCompanyName.Text, txtTask.Text, txtCompanyAuthorized.Text, txtTc.Text, txtCompanySector.Text, txtCompanyPhone1.Text, txtCompanyPhone2.Text, txtCompanyPhone3.Text, txtCompanyMail.Text, txtCompanyFax.Text, Convert.ToInt32(cmdCompanyCity.SelectedValue), Convert.ToInt32(cmdCompanyCounty.SelectedValue), txtCompanyTax.Text, txtCompanyAddress.Text, txtCode1.Text, txtCode2.Text, txtCode3.Text);
            if (getCompany == 0) message = "Firma Adı, Sektör, Yetkili, Görev, T.C Numarası, Telefon 1, Fax, Mail, Vergi Dairesi ve Adres kısımlarını boş geçmeyiniz!";
            else if (getCompany == 1) message = "T.C numarası 11 haneden oluşmalı!";
            else if (getCompany == 2) message = "Telefon numarası 11 haneden oluşmalı";
            else if (getCompany == 3) message = "Girilen T.C numarası başka birine aittir.";
            else message = "Kayıt başarılı bir şekilde yapılmıştır.";
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CompanyList();
        }

        private void cmdCompanyCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            city.GetCounty(cmdCompanyCity, cmdCompanyCounty);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message = "";
            CompanyBusiness cB = new CompanyBusiness();
            int getCompany = cB.CompanyUpdate(short.Parse(id), txtCompanyName.Text, txtTask.Text, txtCompanyAuthorized.Text, txtTc.Text, txtCompanySector.Text, txtCompanyPhone1.Text, txtCompanyPhone2.Text, txtCompanyPhone3.Text, txtCompanyMail.Text, txtCompanyFax.Text, Convert.ToInt32(cmdCompanyCity.SelectedValue), Convert.ToInt32(cmdCompanyCounty.SelectedValue), txtCompanyTax.Text, txtCompanyAddress.Text, txtCode1.Text, txtCode2.Text, txtCode3.Text);
            if (getCompany == 0) message = "Firma Adı, Sektör, Yetkili, Görev, T.C Numarası, Telefon 1, Fax, Mail, Vergi Dairesi ve Adres kısımlarını boş geçmeyiniz!";
            else if (getCompany == 1) message = "T.C numarası 11 haneden oluşmalı!";
            else if (getCompany == 2) message = "Telefon numarası 11 haneden oluşmalı";
            else if (getCompany == 3) message = "Girilen T.C numarası başka birine aittir.";
            else message = "Güncelleme başarılı bir şekilde yapılmıştır.";
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CompanyList();
        }
        int secilen;
        string id;
        private void gridCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = gridCompany.SelectedCells[0].RowIndex;
            id = gridCompany.Rows[secilen].Cells[0].Value.ToString();
            txtCompanyName.Text = gridCompany.Rows[secilen].Cells[1].Value.ToString();
            txtTask.Text = gridCompany.Rows[secilen].Cells[2].Value.ToString();
            txtCompanyAuthorized.Text = gridCompany.Rows[secilen].Cells[3].Value.ToString();
            txtTc.Text = gridCompany.Rows[secilen].Cells[4].Value.ToString();
            txtCompanySector.Text = gridCompany.Rows[secilen].Cells[5].Value.ToString();
            txtCompanyPhone1.Text = gridCompany.Rows[secilen].Cells[6].Value.ToString();
            txtCompanyPhone2.Text = gridCompany.Rows[secilen].Cells[7].Value.ToString();
            txtCompanyPhone3.Text = gridCompany.Rows[secilen].Cells[8].Value.ToString();
            txtCompanyMail.Text = gridCompany.Rows[secilen].Cells[9].Value.ToString();
            txtCompanyFax.Text = gridCompany.Rows[secilen].Cells[10].Value.ToString();
            cmdCompanyCity.Text = gridCompany.Rows[secilen].Cells[11].Value.ToString();
            cmdCompanyCounty.Text = gridCompany.Rows[secilen].Cells[12].Value.ToString();
            txtCompanyTax.Text = gridCompany.Rows[secilen].Cells[13].Value.ToString();
            txtCompanyAddress.Text = gridCompany.Rows[secilen].Cells[14].Value.ToString();
            txtCode1.Text = gridCompany.Rows[secilen].Cells[15].Value.ToString();
            txtCode2.Text = gridCompany.Rows[secilen].Cells[16].Value.ToString();
            txtCode3.Text = gridCompany.Rows[secilen].Cells[17].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CompanyBusiness cB = new CompanyBusiness();
            int getDelete = cB.CompanyDelete(short.Parse(id));
            if (getDelete > 0) MessageBox.Show("Kayıt Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CompanyList();
        }
    }
}
