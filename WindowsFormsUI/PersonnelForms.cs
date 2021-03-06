using BusinessLogicLayer;
using DatabaseLogicLayer;
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
    public partial class PersonnelForms : Form
    {
        public PersonnelForms()
        {
            InitializeComponent();
        }
        TaskDatabase tD = new TaskDatabase();
        City city = new City();
        private void btnPersonnelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string durum = "";
            PersonnelBusiness cB = new PersonnelBusiness();
            int getData = cB.PersonnelAdd(txtPersonnelFirstName.Text, txtPersonnelLastname.Text, txtPersonnelPhone.Text, txtPersonnelTc.Text, txtPersonelMail.Text, Convert.ToInt32(cmdPersonnelCity.SelectedValue), Convert.ToInt32(cmdPersonnelCounty.SelectedValue), txtPersonnelAddress.Text, Convert.ToInt32(cmdPersonnelTask.Text));
            if (getData == -1) durum = "T.C kimlik numarası başka birine aittir!";
            else if (getData == 0) durum = "Ad,Soyad,Telefon 1,T.C,Mail,Adres ve Vergi Dairesi alanlarının dolu olduğuna emin olun!";
            else if (getData == 1) durum = "Telefon 1 numarası hatalı'";
            else if (getData == 2) durum = "Telefon 2 numarası hatalı'";
            else if (getData == 3) durum = "T.C numarası hatalı'";
            else durum = "Kayıt İşlemi Başarılı!!!";
            MessageBox.Show(durum, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PersonnelForms_Load(object sender, EventArgs e)
        {
            tD.TaskList(cmdPersonnelTask);
            city.GetCity(cmdPersonnelCity);
        }

        private void cmdPersonnelCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            city.GetCounty(cmdPersonnelCity, cmdPersonnelCounty);
        }
    }
}
