using System;
using System.Collections;
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
    public partial class ProductExplanationForms : Form
    {
        public ArrayList degerler;
        public ProductExplanationForms()
        {
            InitializeComponent();
            degerler = new ArrayList();
        }

        private void ProductExplanationForms_Load(object sender, EventArgs e)
        {
            if (degerler.Count > 0)
            {
                txtProductName.Text = degerler[1].ToString();
                txtProductBrand.Text = degerler[2].ToString();
                txtProductModel.Text = degerler[3].ToString();
                txtProductYear.Text = degerler[4].ToString();
                txtProductNumber.Text = degerler[5].ToString();
                txtProductCost.Text = degerler[6].ToString();
                txtProductSales.Text = degerler[7].ToString();
                txtProductDiscount.Text = degerler[8].ToString();
                txtProductVAT.Text = degerler[9].ToString();
                txtProductExplanation.Text = degerler[10].ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
