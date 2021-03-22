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
            SaleForms frm = new SaleForms();
            GetForm(frm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForms frm = new LoginForms();
            frm.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            PersonnelForms frm = new PersonnelForms();
            GetForm(frm);
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            GuideForms frm = new GuideForms();
            GetForm(frm);
        }

        private void btnDebt_Click(object sender, EventArgs e)
        {
            DebtForms frm = new DebtForms();
            GetForm(frm);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            InvoiceForms frm = new InvoiceForms();
            GetForm(frm);
        }
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
        private void btnHomePage_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnHomePage.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnHomePage_MouseLeave(object sender, EventArgs e)
        {
            this.btnHomePage.BackgroundImageLayout = ImageLayout.Center;
        }

        private void btnProduct_MouseMove_1(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void btnProduct_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImageLayout = ImageLayout.Center;

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockForms frm = new StockForms();
            GetForm(frm);
        }
    }
}
