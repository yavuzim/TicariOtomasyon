using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BusinessLogicLayer;
using DatabaseLogicLayer;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class LoginForms : Form
    {
        public LoginForms()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SystemUser systemUser = new SystemUser();
            SystemUserService userService = new SystemUserService();
            int returnResult = userService.SystemLogin(txtUsername.Text, txtPassword.Text);
            if (returnResult > 0)
            {
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            else if (returnResult < 0) MessageBox.Show("Kullanıcı Adı veya Şifre yanlış");
            else MessageBox.Show("Boş geçilmez.");
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }
    }
}
