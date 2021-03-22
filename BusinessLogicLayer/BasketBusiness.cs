using DatabaseLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BusinessLogicLayer
{
    public class BasketBusiness
    {
        public void BasketList(ListView listView)
        {
            SqlDataReader read = null;
            using (BasketDatabase bD = new BasketDatabase())
            {
                read = bD.BasketList();
                while (read.Read())
                {
                    ListViewItem lst = new ListViewItem(read["SepetID"].ToString());
                    lst.SubItems.Add(read["MusteriAdi"].ToString());
                    lst.SubItems.Add(read["MusteriSoyad"].ToString());
                    lst.SubItems.Add(read["UrunAd"].ToString());
                    lst.SubItems.Add(read["MarkaAd"].ToString());
                    lst.SubItems.Add(read["UrunModel"].ToString());
                    lst.SubItems.Add(read["Adet"].ToString());
                    lst.SubItems.Add(read["Tutar"].ToString());
                    listView.Items.Add(lst);
                }
            }
        }
    }
}
