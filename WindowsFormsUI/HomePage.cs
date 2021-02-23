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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        void GetForm(Form frm)
        {
            downPanel.Controls.Clear();
            frm.MdiParent = this;
            downPanel.Controls.Add(frm);
            frm.Show();
        }
        private void btnHomePage_Click(object sender, EventArgs e)
        {
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForms frm = new ProductForms();
            GetForm(frm);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForms frm = new CustomerForms();
            GetForm(frm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForms frm = new LoginForms();
            frm.Show();
        }
    }
}
