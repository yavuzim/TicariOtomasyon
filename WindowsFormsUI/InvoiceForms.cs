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
namespace WindowsFormsUI
{
    public partial class InvoiceForms : Form
    {
        public InvoiceForms()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Invoicelist()
        {
            string[] basliklar = { "id", "Seri", "Sıra No", "Tarih", "Vergi Dairesi", "Müşteri No", "Alıcı", "Alıcı Tel", "Alıcı Mail", "Teslim Eden", "Teslim Alan", "Ürün", "Marka", "Model", "Ödenecek Tutar" };
            InvoiceBusiness iBusiness = new InvoiceBusiness();
            iBusiness.InvoiceList(gridInvoice);
            for (int i = 0; i < basliklar.Length; i++)
            {
                gridInvoice.Columns[i].HeaderText = basliklar[i];
            }
            gridInvoice.RowHeadersVisible = false;
            gridInvoice.Columns[0].Visible = false;
        }
        private void InvoiceForms_Load(object sender, EventArgs e)
        {
            Invoicelist();
        }
    }
}
