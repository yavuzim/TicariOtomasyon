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
    public partial class ProductForms : Form
    {
        ProductAddUpdate Pb;
        ProductExplanationForms PEF;
        public ProductForms()
        {
            InitializeComponent();
            Pb = new ProductAddUpdate();
            PEF = new ProductExplanationForms();
        }

        private void btnProductExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void ProductList()
        {
            ProductBusiness pBusiness = new ProductBusiness();
            List<Products> products = pBusiness.ProductList();
            gridProducts.DataSource = products;
            gridProducts.RowHeadersVisible = false;
            gridProducts.Columns[0].Visible = false;
            gridProducts.Columns[1].HeaderText = "ÜRÜN AD";
            gridProducts.Columns[2].HeaderText = "ÜRÜN MARKA";
            gridProducts.Columns[3].HeaderText = "ÜRÜN MODEL";
            gridProducts.Columns[4].HeaderText = "YIL";
            gridProducts.Columns[5].HeaderText = "ALIŞ FİYAT";
            gridProducts.Columns[6].HeaderText = "SATIŞ FİYAT";
            gridProducts.Columns[7].HeaderText = "İNDİRİM";
            gridProducts.Columns[8].HeaderText = "KDV ORANI";
            gridProducts.Columns[9].HeaderText = "DETAY";
            gridProducts.Columns[9].Width = 312;
        }
        private void ProductForms_Load(object sender, EventArgs e)
        {
            ProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Pb.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductAddUpdate frm = new ProductAddUpdate();
            frm.ShowDialog();
        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            ProductList();
        }
        int secilen;
        public int adet;
        private void gridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = gridProducts.SelectedCells[0].RowIndex;
            Pb.degerler.Clear();
            PEF.degerler.Clear();
            for (int i = 0; i < 10; i++)
            {
                string d = gridProducts.Rows[secilen].Cells[i].Value.ToString();
                Pb.degerler.Add(d);
                PEF.degerler.Add(d);
            }
        }

        private void btnExplanation_Click(object sender, EventArgs e)
        {
            if (PEF.degerler.Count > 0)
                PEF.ShowDialog();
            else MessageBox.Show("Ürün Detayı İçin Lütfen Ürün Seçiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
