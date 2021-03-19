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
using BusinessLogicLayer;
using DatabaseLogicLayer;
using Entities;

namespace WindowsFormsUI
{
    public partial class ProductAddUpdate : Form
    {
        public ArrayList degerler;
        public ProductAddUpdate()
        {
            InitializeComponent();
            degerler = new ArrayList();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductBusiness pB = new ProductBusiness();
            if (txtProductCost.Text == "" || txtProductSales.Text == "" || txtPrdocutDiscount.Text == "" || txtProductVAT.Text == "")
            {
                txtProductCost.Text = "0";
                txtProductSales.Text = "0";
                txtPrdocutDiscount.Text = "0";
                txtProductVAT.Text = "0";
            }
            int getProduct = pB.ProductAdd(txtProductName.Text, cmdProductBrand.SelectedIndex + 1, txtProductModel.Text, txtProductYear.Text, decimal.Parse(txtProductCost.Text), decimal.Parse(txtProductSales.Text), int.Parse(txtPrdocutDiscount.Text), decimal.Parse(txtProductVAT.Text), txtProductExplanation.Text);
            if (getProduct == -1) MessageBox.Show("Boş Geçilmez", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (getProduct == 0) MessageBox.Show("Yıl Bilgisi Hatalı", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (getProduct == 1) MessageBox.Show("Alış ve Satış Fiyat Bilgileri Hatalı", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (getProduct == 2) MessageBox.Show("İndirim Bilgisi Hatalı", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (getProduct == 3) MessageBox.Show("KDV Bilgisi Hatalı", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                timer1.Enabled = true;
                lblSonuc.Visible = true;
                lblSonuc.Text = "Ürün Ekleme İşlemi Başarılı";
                timer1.Interval = 1000;
            }

        }
        private void BrandList()
        {
            ProductBrandBusiness pb = new ProductBrandBusiness();
            ProductBrand pBrand = new ProductBrand();
            List<ProductBrand> pbList = pb.BrandList();
            cmdProductBrand.ValueMember = pBrand.MarkaID.ToString();
            cmdProductBrand.DisplayMember = pBrand.MarkaAd;
            cmdProductBrand.DataSource = pbList;
        }
        int id;
        private void ProductAddUpdate_Load(object sender, EventArgs e)
        {
            BrandList();
            if (degerler.Count > 0)
            {
                id = Convert.ToInt32(degerler[0]);
                txtProductName.Text = degerler[1].ToString();
                cmdProductBrand.Text = degerler[2].ToString();
                txtProductModel.Text = degerler[3].ToString();
                txtProductYear.Text = degerler[4].ToString();
                txtProductCost.Text = degerler[5].ToString();
                txtProductSales.Text = degerler[6].ToString();
                txtPrdocutDiscount.Text = degerler[7].ToString();
                txtProductVAT.Text = degerler[8].ToString();
                txtProductExplanation.Text = degerler[9].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductBusiness pB = new ProductBusiness();
            int getProduct = pB.ProductUpdate(id, txtProductName.Text, cmdProductBrand.SelectedIndex + 1, txtProductModel.Text, txtProductYear.Text, decimal.Parse(txtProductCost.Text), decimal.Parse(txtProductSales.Text), int.Parse(txtPrdocutDiscount.Text), decimal.Parse(txtProductVAT.Text), txtProductExplanation.Text);
            if (getProduct == -1) MessageBox.Show("Boş Geçilmez", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (getProduct == 0) MessageBox.Show("Yıl Bilgisi Hatalı", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (getProduct == 1) MessageBox.Show("Alış ve Satış Fiyat Bilgileri Hatalı", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (getProduct == 2) MessageBox.Show("İndirim Bilgisi Hatalı", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (getProduct == 3) MessageBox.Show("KDV Bilgisi Hatalı", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                timer1.Enabled = true;
                lblSonuc.Visible = true;
                lblSonuc.Text = "Ürün Güncelleme İşlemi Başarılı";
                timer1.Interval = 1000;
            }
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 10)
            {
                sayac = 0;
                lblSonuc.Visible = false;
                timer1.Enabled = false;
            }
        }
    }
}
