using BusinessLogicLayer;
using Entities;
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
    public partial class SaleForms : Form
    {
        public SaleForms()
        {
            InitializeComponent();
        }

        private void btnCustomerExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ProductBrandList()
        {
            List<ProductBrand> brandList = new ProductBrandBusiness().BrandList();
            BrandCheckList.DataSource = brandList;
            BrandCheckList.DisplayMember = "MarkaAd";
            BrandCheckList.ValueMember = "MarkaID";

        }
        void ProductList()
        {
            StockBusiness sB = new StockBusiness();
            List<StockList> stockList = sB.StockList();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = stockList;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[8].Width = 92;
            dataGridView1.Columns[2].HeaderText = "ÜRÜN";
            dataGridView1.Columns[3].HeaderText = "MARKA";
            dataGridView1.Columns[4].HeaderText = "MODEL";
            dataGridView1.Columns[5].HeaderText = "ÜRÜN DETAY";
            dataGridView1.Columns[6].HeaderText = "STOK ADET";
            dataGridView1.Columns[7].HeaderText = "SATIŞ FİYAT";
            dataGridView1.Columns[8].HeaderText = "İNDİRİM";
            dataGridView1.Columns[9].HeaderText = "KDV";
        }
        private void SaleForms_Load(object sender, EventArgs e)
        {
            ProductList();
            ProductBrandList();
        }

        private void GetBasket_Click(object sender, EventArgs e)
        {
            BasketForms frm = new BasketForms();
            frm.ShowDialog();
        }
        int secilen = -1;
        string id, adet, satisFiyat, stockId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            stockId = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            adet = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            satisFiyat = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
            string message = "";
            BasketBusiness bBusiness = new BasketBusiness();
            if (secilen > -1)
            {
                if (txtNumber.Text == "") message = "Lütfen Adet Giriniz";
                else
                {
                    if (int.Parse(txtNumber.Text) > int.Parse(adet) || int.Parse(txtNumber.Text) < 0) message = "Girilen adet stokta yok";

                    else
                    {
                        decimal Tutar = decimal.Parse(satisFiyat) * short.Parse(txtNumber.Text);
                        int getBsaket = bBusiness.BasketAdd(int.Parse(id), short.Parse(txtNumber.Text), Tutar);
                        if (getBsaket == 1)
                        {
                            message = "Ürün Sepete Eklendi";
                            int stock;
                            stock = int.Parse(adet) - int.Parse(txtNumber.Text);
                            StockBusiness sBusiness = new StockBusiness();
                            int getStock = sBusiness.StockUpdate(int.Parse(stockId), int.Parse(id), stock);
                        }
                    }
                }
            }
            else message = "Lütfen Ürün Seçiniz";
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); ProductList();
            secilen = -1;
        }
    }
}
