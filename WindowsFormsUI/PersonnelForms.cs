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
            int getData = cB.PersonnelAdd(txtPersonnelFirstName.Text, txtPersonnelLastname.Text, txtPersonnelPhone.Text, txtPersonnelTc.Text, txtPersonelMail.Text, Convert.ToInt32(cmdPersonnelCity.SelectedValue), Convert.ToInt32(cmdPersonnelCounty.SelectedValue), Convert.ToInt32(cmdPersonnelTask.SelectedValue), txtPersonnelAddress.Text);
            if (getData == -1) durum = "T.C kimlik numarası başka birine aittir!";
            else if (getData == 0) durum = "Ad,Soyad,Telefon 1,T.C,Mail,Adres ve Vergi Dairesi alanlarının dolu olduğuna emin olun!";
            else if (getData == 1) durum = "Telefon 1 numarası hatalı'";
            else if (getData == 2) durum = "Telefon 2 numarası hatalı'";
            else if (getData == 3) durum = "T.C numarası hatalı'";
            else durum = "Kayıt İşlemi Başarılı!!!";
            MessageBox.Show(durum, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonnelList();
        }
        void PersonnelList()
        {
            PersonnelBusiness pb = new PersonnelBusiness();
            pb.PersonnelList(gridPersonnel);
            gridPersonnel.RowHeadersVisible = false;
            gridPersonnel.Columns[0].Visible = false;
            string[] columnName = { "ID", "AD", "SOYAD", "TELEFON 1", "T.C NUMARASI", "E-POSTA", "ŞEHİR", "İLÇE", "ADRES", "GÖREV" };
            for (int i = 0; i < columnName.Length; i++)
            {
                gridPersonnel.Columns[i].HeaderText = columnName[i];
            }
            gridPersonnel.Columns[5].Width = 180;
            gridPersonnel.Columns[8].Width = 310;
        }
        private void PersonnelForms_Load(object sender, EventArgs e)
        {
            PersonnelList();
            tD.TaskList(cmdPersonnelTask);
            city.GetCity(cmdPersonnelCity);
        }

        private void cmdPersonnelCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            city.GetCounty(cmdPersonnelCity, cmdPersonnelCounty);
        }
        int secilen;
        string id;
        public string _TC;
        private void gridPersonnel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = gridPersonnel.SelectedCells[0].RowIndex;
            id = gridPersonnel.Rows[secilen].Cells[0].Value.ToString();
            txtPersonnelFirstName.Text = gridPersonnel.Rows[secilen].Cells[1].Value.ToString();
            txtPersonnelLastname.Text = gridPersonnel.Rows[secilen].Cells[2].Value.ToString();
            txtPersonnelPhone.Text = gridPersonnel.Rows[secilen].Cells[3].Value.ToString();
            txtPersonnelTc.Text = gridPersonnel.Rows[secilen].Cells[4].Value.ToString();
            txtPersonelMail.Text = gridPersonnel.Rows[secilen].Cells[5].Value.ToString();
            cmdPersonnelCity.Text = gridPersonnel.Rows[secilen].Cells[6].Value.ToString();
            cmdPersonnelCounty.Text = gridPersonnel.Rows[secilen].Cells[7].Value.ToString();
            txtPersonnelAddress.Text = gridPersonnel.Rows[secilen].Cells[8].Value.ToString();
            cmdPersonnelTask.Text = gridPersonnel.Rows[secilen].Cells[9].Value.ToString();
            _TC = gridPersonnel.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string durum = "";
            PersonnelBusiness pB = new PersonnelBusiness();
            int getData = pB.PersonnelUpdate(int.Parse(id), txtPersonnelFirstName.Text, txtPersonnelLastname.Text, txtPersonnelPhone.Text, txtPersonnelTc.Text, _TC, txtPersonelMail.Text, Convert.ToInt32(cmdPersonnelCity.SelectedValue), Convert.ToInt32(cmdPersonnelCounty.SelectedValue), Convert.ToInt32(cmdPersonnelTask.SelectedValue), txtPersonnelAddress.Text);
            if (getData == -1) durum = "T.C kimlik numarası başka birine aittir!";
            else if (getData == 0) durum = "Ad,Soyad,Telefon 1,T.C,Mail ve Adres alanlarının dolu olduğuna emin olun!";
            else if (getData == 1) durum = "Telefon 1 numarası hatalı'";
            else if (getData == 2) durum = "Telefon 2 numarası hatalı'";
            else if (getData == 3) durum = "T.C numarası hatalı'";
            else durum = "Güncelleme İşlemi Başarılı!!!";
            MessageBox.Show(durum, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonnelList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id == null) MessageBox.Show("Kayıt Seçiniz!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                PersonnelBusiness pB = new PersonnelBusiness();
                int getDelete = pB.PersonnelDelete(int.Parse(id));
                if (getDelete > 0) MessageBox.Show("Kayıt Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PersonnelList();
        }
    }
}
