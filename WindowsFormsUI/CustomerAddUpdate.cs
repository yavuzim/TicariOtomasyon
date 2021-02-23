using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLogicLayer;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace WindowsFormsUI
{
    public partial class CustomerAddUpdate : Form
    {
        City city = new City();
        public ArrayList degerler;
        public CustomerAddUpdate()
        {
            InitializeComponent();
            degerler = new ArrayList();
        }
        int id;
        public string _TC;
        private void CustomerAddUpdate_Load(object sender, EventArgs e)
        {
            city.GetCity(cmdCustomerCity);
            if (degerler.Count > 0)
            {
                id = Convert.ToInt32(degerler[0]);
                txtCustomerName.Text = degerler[1].ToString();
                txtCustomerLastname.Text = degerler[2].ToString();
                txtCustomerPhone1.Text = degerler[3].ToString();
                txtCustomerPhone2.Text = degerler[4].ToString();
                txtCustomerTC.Text = degerler[5].ToString();
                txtCustomerMail.Text = degerler[6].ToString();
                cmdCustomerCity.Text = degerler[7].ToString();
                cmdCustomerCounty.Text = degerler[8].ToString();
                txtCustomerAddress.Text = degerler[9].ToString();
                txtCustomerTax.Text = degerler[10].ToString();
                _TC = degerler[5].ToString();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string durum = "";
            CustomerBusiness cB = new CustomerBusiness();
            int getData = cB.CustomerAdd(txtCustomerName.Text, txtCustomerLastname.Text, txtCustomerPhone1.Text, txtCustomerPhone2.Text, txtCustomerTC.Text, txtCustomerMail.Text, Convert.ToInt32(cmdCustomerCity.SelectedValue), Convert.ToInt32(cmdCustomerCounty.SelectedValue), txtCustomerAddress.Text, txtCustomerTax.Text);
            if (getData == -1) durum = "T.C kimlik numarası başka birine aittir!";
            else if (getData == 0) durum = "Ad,Soyad,Telefon 1,T.C,Mail,Adres ve Vergi Dairesi alanlarının dolu olduğuna emin olun!";
            else if (getData == 1) durum = "Telefon 1 numarası hatalı'";
            else if (getData == 2) durum = "Telefon 2 numarası hatalı'";
            else if (getData == 3) durum = "T.C numarası hatalı'";
            else durum = "Kayıt İşlemi Başarılı!!!";
            MessageBox.Show(durum, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string durum = "";
            CustomerBusiness cB = new CustomerBusiness();
            int getData = cB.CustomerUpdate(id, txtCustomerName.Text, txtCustomerLastname.Text, txtCustomerPhone1.Text, txtCustomerPhone2.Text, txtCustomerTC.Text, _TC,txtCustomerMail.Text, Convert.ToInt32(cmdCustomerCity.SelectedValue), Convert.ToInt32(cmdCustomerCounty.SelectedValue), txtCustomerAddress.Text, txtCustomerTax.Text);
            if (getData == -1) durum = "T.C kimlik numarası başka birine aittir!";
            else if (getData == 0) durum = "Ad,Soyad,Telefon 1,T.C,Mail,Adres ve Vergi Dairesi alanlarının dolu olduğuna emin olun!";
            else if (getData == 1) durum = "Telefon 1 numarası hatalı'";
            else if (getData == 2) durum = "Telefon 2 numarası hatalı'";
            else if (getData == 3) durum = "T.C numarası hatalı'";
            else durum = "Güncelleme İşlemi Başarılı!!!";
            MessageBox.Show(durum, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdCustomerCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            city.GetCounty(cmdCustomerCity, cmdCustomerCounty);
        }
    }
}
