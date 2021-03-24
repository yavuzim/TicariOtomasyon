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
        public int BasketAdd(int Urun, short Adet, decimal Tutar)
        {
            int resultReturn = 0;
            using (BasketDatabase bD = new BasketDatabase())
            {
                    resultReturn = bD.BasketAdd(Urun, Adet, Tutar);
            }
            return resultReturn;
        }
        public List<int> BasketListKontrol()
        {
            SqlDataReader read = null;
            List<int> basketControl = new List<int>();
            using (BasketDatabase bD = new BasketDatabase())
            {
                read = bD.BasketList();
                while (read.Read())
                {
                    basketControl.Add(Convert.ToInt32(read["UrunAd"]));
                }
            }
            return basketControl;
        }
        public void BasketList(ListView listView)
        {
            SqlDataReader read = null;
            using (BasketDatabase bD = new BasketDatabase())
            {
                read = bD.BasketList();
                while (read.Read())
                {
                    ListViewItem lst = new ListViewItem(read["SepetID"].ToString());
                    lst.SubItems.Add(read["UrunAd"].ToString());
                    lst.SubItems.Add(read["MarkaAd"].ToString());
                    lst.SubItems.Add(read["UrunModel"].ToString());
                    lst.SubItems.Add(read["SatisFiyat"].ToString());
                    lst.SubItems.Add(read["Adet"].ToString());
                    lst.SubItems.Add(read["Tutar"].ToString());
                    listView.Items.Add(lst);
                }
            }
        }
    }
}
