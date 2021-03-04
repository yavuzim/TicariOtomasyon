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
    }
}
