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
    public partial class StockAddUpdate : Form
    {
        public StockAddUpdate()
        {
            InitializeComponent();
        }
        void ProductsList()
        {
            ProductBusiness pB = new ProductBusiness();
            List<Products> getProducts = pB.ProductList();
            gridStocks.DataSource = getProducts;
            gridStocks.RowHeadersVisible = false;
            gridStocks.Columns[0].Visible = false;
            for (int i = 4; i < gridStocks.Columns.Count; i++)
            {
                gridStocks.Columns[i].Visible = false;
            }
            gridStocks.Columns[1].HeaderText = "ÜRÜN AD";
            gridStocks.Columns[2].HeaderText = "ÜRÜN MARKA";
            gridStocks.Columns[3].HeaderText = "ÜRÜN MODEL";
            gridStocks.Columns[3].Width = 65;
        }
        private void StockAddUpdate_Load(object sender, EventArgs e)
        {
            ProductsList();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int secilen;
        string id;
        private void gridStocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = gridStocks.SelectedCells[0].RowIndex;
            id = gridStocks.Rows[secilen].Cells[0].Value.ToString();
            lblName.Text = gridStocks.Rows[secilen].Cells[1].Value.ToString();
            lblBrand.Text = gridStocks.Rows[secilen].Cells[2].Value.ToString();
            lblModel.Text = gridStocks.Rows[secilen].Cells[3].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            txtNumber.Minimum = 0;
            txtNumber.Maximum = short.MaxValue;
            string adet = txtNumber.Value.ToString();
            StockBusiness sB = new StockBusiness();
            int getStock = sB.StockAdd(id, short.Parse(adet));
            if (getStock == 0) message = "Lütfen Ürün Seçiniz!";
            else if (getStock == 1) message = "Lütfen Adet Değerini En Az 0 Giriniz!";
            else if (getStock == 2) message = lblName.Text + " " + "Ürününe Stok Eklendi";
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
