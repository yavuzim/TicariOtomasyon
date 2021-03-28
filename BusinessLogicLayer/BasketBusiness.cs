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
        public int BasketAdd(int Urun, int Adet, decimal Tutar)
        {
            int resultReturn = 0;
            bool kontrol = false;
            decimal satisFiyat = 0;
            using (BasketDatabase bD = new BasketDatabase())
            {
                for (int i = 0; i < BasketListKontrol().Count; i++)
                {
                    if (Urun == BasketListKontrol()[i])
                    {
                        //satisFiyat = Tutar / Adet;
                        kontrol = true;
                        break;
                    }
                }
                if (kontrol)
                    resultReturn = bD.BasketUpdate(Urun, Adet, Tutar);
                else
                    resultReturn = bD.BasketAdd(Urun, Adet, Tutar);
            }
            return resultReturn;
        }
        //public int BasketUpdate(int id, int adet)
        //{
        //    int resultReturn = 0;
        //    using (BasketDatabase bD = new BasketDatabase())
        //    {
        //        resultReturn = bD.BasketUpdate(id, adet);
        //    }
        //    return resultReturn;
        //}
        List<decimal> satisList = new List<decimal>();
        public List<int> BasketListKontrol()
        {
            SqlDataReader read = null;
            List<int> basketKontrol = new List<int>();
            using (BasketDatabase bD = new BasketDatabase())
            {
                read = bD.BasketListKontrol();
                while (read.Read())
                {
                    basketKontrol.Add(Convert.ToInt32(read["UrunID"]));
                    satisList.Add(Convert.ToDecimal(read["SatisFiyat"]));
                }
            }
            return basketKontrol;
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
