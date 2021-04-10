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
namespace WindowsFormsUI
{
    public partial class InvoiceAddForms : Form
    {
        List<int> indis;
        public InvoiceAddForms(List<int> _indis)
        {
            InitializeComponent();
            indis = _indis;
        }
        BasketBusiness basketB = new BasketBusiness();
        List<int> basketId;
        List<decimal> tutar;
        void BasketList()
        {
            basketId = new List<int>();
            tutar = new List<decimal>();
            int sayac = 0;
            basketB.BasketListKontrol();
            for (int i = 0; i < basketB.sepetid.Count; i++)
            {
                if (i == indis[sayac])
                {
                    sayac++;
                    basketId.Add(basketB.basketKontrol[i]);
                    tutar.Add(basketB.tutar[i]);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        InvoiceBusiness invoiceBusiness = new InvoiceBusiness();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int addInvoice = 0, numara;
            string mesaj = "";
            if (txtMusteriNo.Text == "")
                numara = 0;
            else
                numara = int.Parse(txtMusteriNo.Text);
            BasketList();
            for (int i = 0; i < basketId.Count; i++)
            {
                addInvoice = invoiceBusiness.InvoiceAdd(txtSeri.Text, txtSira.Text, txtDate.Value, txtVergiDairesi.Text, numara, txtAlici.Text, txtAliciTel.Text, txtAliciMail.Text, txtTeslimEden.Text, txtTeslimAlan.Text, basketId[i], tutar[i]);
            }
            if (addInvoice == 1) mesaj = "Boş Geçilmez";
            else mesaj = "Fatura Eklendi";
            MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            basketB.BasketDelete(indis);
        }

        private void InvoiceAddForms_Load(object sender, EventArgs e)
        {
        }
    }
}
