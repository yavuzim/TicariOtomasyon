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
        public ProductForms()
        {
            InitializeComponent();
            Pb = new ProductAddUpdate();
        }

        private void btnProductExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void GridColor(DataGridView dg)
        {          
            for (int i = 0; i < gridProducts.Rows.Count; i++)
            {
                Application.DoEvents();
                DataGridViewCellStyle color = new DataGridViewCellStyle();
                if (Convert.ToInt32(gridProducts.Rows[i].Cells["Durum"].Value) == 1)
                {
                    color.BackColor = Color.Red;
                    color.ForeColor = Color.White;
                }
                dg.Rows[i].DefaultCellStyle = color;
            }
        }
        public void ProductList()
        {
            ProductBusiness pBusiness = new ProductBusiness();
            List<Products> products = pBusiness.ProductList();
            gridProducts.DataSource = products;
            gridProducts.RowHeadersVisible = false;
            gridProducts.Columns[0].Visible = false;
            gridProducts.Columns[10].Visible = false;
            gridProducts.Columns[1].HeaderText = "ÜRÜN AD";
            gridProducts.Columns[2].HeaderText = "ÜRÜN MARKA";
            gridProducts.Columns[3].HeaderText = "ÜRÜN MODEL";
            gridProducts.Columns[4].HeaderText = "YIL";
            gridProducts.Columns[5].HeaderText = "ALIŞ FİYAT";
            gridProducts.Columns[6].HeaderText = "SATIŞ FİYAT";
            gridProducts.Columns[7].HeaderText = "İNDİRİM";
            gridProducts.Columns[8].HeaderText = "KDV ORANI";
            gridProducts.Columns[9].HeaderText = "DETAY";
            gridProducts.Columns[3].Width = 200;
            gridProducts.Columns[9].Width = 500;

        }
        private void ProductForms_Load(object sender, EventArgs e)
        {           
            ProductList(); 
            GridColor(gridProducts);
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
        int secilen;
        public int adet;
        private void gridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = gridProducts.SelectedCells[0].RowIndex;
            Pb.degerler.Clear();
            for (int i = 0; i < 10; i++)
            {
                string d = gridProducts.Rows[secilen].Cells[i].Value.ToString();
                Pb.degerler.Add(d);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ProductList();
            GridColor(gridProducts);
        }
    }
}
