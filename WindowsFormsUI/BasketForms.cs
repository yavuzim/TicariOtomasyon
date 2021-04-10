using BusinessLogicLayer;
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
    public partial class BasketForms : Form
    {
        public BasketForms()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void BasketList()
        {
            listView1.Columns.Clear();
            string[] columns = { "SepetID", "Ürün", "Ürün Marka", "Ürün Model", "Satış Fiyat", "Adet", "Tutar" };
            for (int i = 0; i < columns.Length; i++)
                listView1.Columns.Add(columns[i], 100);
            listView1.Items.Clear();
            BasketBusiness bB = new BasketBusiness();
            bB.BasketList(listView1);

        }
        private void BasketForms_Load(object sender, EventArgs e)
        {
            BasketList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int secilenSayi = listView1.CheckedItems.Count;
            List<int> indis = new List<int>();
            foreach (ListViewItem seciliKayitBilgisi in listView1.CheckedItems)
                indis.Add(seciliKayitBilgisi.Index);
            int deger = new BasketBusiness().BasketDelete(indis);
            if (deger == 1) MessageBox.Show("Silme İşlemi Başarılı!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BasketList();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            int secilenSayi = listView1.CheckedItems.Count;
            List<int> indis = new List<int>();
            foreach (ListViewItem seciliKayitBilgisi in listView1.CheckedItems)
                indis.Add(seciliKayitBilgisi.Index);
            InvoiceAddForms frm = new InvoiceAddForms(indis);
            frm.ShowDialog();
        }
    }
}
