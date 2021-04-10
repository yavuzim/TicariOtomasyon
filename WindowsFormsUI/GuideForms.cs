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
