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
        private void SaleForms_Load(object sender, EventArgs e)
        {
            ProductBrandList();
        }

        private void GetBasket_Click(object sender, EventArgs e)
        {
            BasketForms frm = new BasketForms();
            frm.ShowDialog();
        }
    }
}
