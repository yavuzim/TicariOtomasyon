using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace WindowsFormsUI
{
    public partial class MailForms : Form
    {
       public List<string> getMail;
        public MailForms()
        {
            InitializeComponent();
            getMail = new List<string>();
        }

        private void MailForms_Load(object sender, EventArgs e)
        {
            txtMail.Text = getMail[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailMessage Email = new MailMessage();
            Email.To.Add("yavuz.imer133@gmail.com");
        }
    }
}
