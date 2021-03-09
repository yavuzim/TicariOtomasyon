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
using Entities;

namespace WindowsFormsUI
{
    public partial class GuideForms : Form
    {
        public GuideForms()
        {
            InitializeComponent();
        }

        private void btnCompanyrExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuideForms_Load(object sender, EventArgs e)
        {
            CustomerBusiness pB = new CustomerBusiness();
            pB.CustomerList(gridCustomer);
            gridCustomer.RowHeadersVisible = false;
            gridCustomer.Columns[0].Visible = false;
            gridCustomer.Columns[5].Visible = false;
            gridCustomer.Columns[7].Visible = false;
            gridCustomer.Columns[8].Visible = false;
            gridCustomer.Columns[9].Visible = false;
            gridCustomer.Columns[10].Visible = false;
            gridCustomer.Columns[1].Width = 284;
            gridCustomer.Columns[2].Width = 284;
            gridCustomer.Columns[3].Width = 284;
            gridCustomer.Columns[4].Width = 284;
            gridCustomer.Columns[6].Width = 286;
            CompanyBusiness cB = new CompanyBusiness();
            List<Company> getData = cB.CompanyList();
            gridCompany.DataSource = getData;
            gridCompany.RowHeadersVisible = false;
            gridCompany.Columns[0].Visible = false;
            gridCompany.Columns[1].Visible = false;
            gridCompany.Columns[2].Visible = false;
            gridCompany.Columns[4].Visible = false;
            gridCompany.Columns[5].Visible = false;
            gridCompany.Columns[11].Visible = false;
            gridCompany.Columns[12].Visible = false;
            gridCompany.Columns[13].Visible = false;
            gridCompany.Columns[14].Visible = false;
            gridCompany.Columns[15].Visible = false;
            gridCompany.Columns[16].Visible = false;
            gridCompany.Columns[17].Visible = false;
            gridCompany.Columns[3].Width = 240;
            gridCompany.Columns[6].Width = 240;
            gridCompany.Columns[7].Width = 240;
            gridCompany.Columns[8].Width = 240;
            gridCompany.Columns[9].Width = 240;
            gridCompany.Columns[10].Width = 234;
        }
        int secilen;
        string email;
        private void gridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = gridCustomer.SelectedCells[0].RowIndex;
            MailForms frm = new MailForms();
            email = gridCustomer.Rows[secilen].Cells[6].Value.ToString();
            frm.getMail.Add(email);
            frm.ShowDialog();
        }
    }
}
