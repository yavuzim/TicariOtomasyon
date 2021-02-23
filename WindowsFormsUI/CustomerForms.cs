using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLogicLayer;
using System.Collections;
using DatabaseLogicLayer;

namespace WindowsFormsUI
{
    public partial class CustomerForms : Form
    {
        CustomerAddUpdate frm;
        public CustomerForms()
        {
            InitializeComponent();
            frm = new CustomerAddUpdate();
        }
        void CustomerList()
        {
            CustomerBusiness cb = new CustomerBusiness();
            cb.CustomerList(gridCustomer);
            gridCustomer.RowHeadersVisible = false;
             gridCustomer.Columns[0].Visible = false;
            string[] columnName = { "ID", "AD", "SOYAD", "TELEFON 1", "TELEFON 2", "T.C NUMARASI", "E-POSTA", "ŞEHİR", "İLÇE", "ADRES", "VERGİ DAİRESİ" };
            for (int i = 0; i < columnName.Length; i++)
            {
                gridCustomer.Columns[i].HeaderText = columnName[i];
            }
            gridCustomer.Columns[10].Width = 312;
        }
        private void CustomerForms_Load(object sender, EventArgs e)
        {
            CustomerList();
        }

        private void btnCustomerExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            CustomerList();
        }
        int secilen;
        public int adet;
        private void gridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = gridCustomer.SelectedCells[0].RowIndex;
            frm.degerler.Clear();
          //  PEF.degerler.Clear();
            for (int i = 0; i < 11; i++)
            {
                string d = gridCustomer.Rows[secilen].Cells[i].Value.ToString();
                frm.degerler.Add(d);
                //PEF.degerler.Add(d);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
        }
    }
}

