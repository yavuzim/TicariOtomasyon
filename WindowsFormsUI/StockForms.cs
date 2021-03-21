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
using Entities;
namespace WindowsFormsUI
{
    public partial class StockForms : Form
    {
        public StockForms()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void StockList()
        {

        }

        private void StockForms_Load(object sender, EventArgs e)
        {
            BrandBusiness bbusiness = new BrandBusiness();
            List<Brand> brandList = bbusiness.BrandList();
            StockBusiness sB = new StockBusiness();
            List<StockList> stockList = sB.StockList();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = stockList;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[1].Width = 253;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            for (int i = 0; i < stockList.Count; i++)
            {
                chart1.Series["Urun"].Points.Add(stockList[i].StokAdet);
                chart1.Series["Urun"].Points[i].AxisLabel = stockList[i].UrunAd.ToString() + " - " + stockList[i].UrunModel.ToString();
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            StockAddUpdate frm = new StockAddUpdate();
            frm.ShowDialog();
        }
    }
}
