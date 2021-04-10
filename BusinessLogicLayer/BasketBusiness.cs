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
            using (BasketDatabase bD = new BasketDatabase())
            {
                for (int i = 0; i < BasketListKontrol().Count; i++)
                {
                    if (Urun == BasketListKontrol()[i])
                    {
                        kontrol = true;
                        break;
                    }
                }
                if (kontrol)
                    resultReturn = bD.BasketUpdate(Urun, Adet, Tutar);
                else
                    resultReturn = bD.BasketAdd(Urun, Adet, Tutar);
                resultReturn = 1;
            }
            return resultReturn;
        }
        public List<int> sepetid = new List<int>();
        public List<decimal> tutar = new List<decimal>();
        public List<int> basketKontrol = new List<int>();
        public int BasketDelete(List<int> indis)
        {
            int resulReturn = 0, sayac = 0;
            using (BasketDatabase bD = new BasketDatabase())
            {
                BasketListKontrol();
                for (int i = 0; i < sepetid.Count; i++)
                {
                    if (i == indis[sayac])
                    {
                        int id = sepetid[i];
                        resulReturn = bD.BasketDelete(id);
                        sayac++;
                        if (sayac == indis.Count)
                        {
                            resulReturn = 1;
                            break;
                        }
                    }
                }
            }
            return resulReturn;
        }
        public List<int> BasketListKontrol()
        {
            tutar.Clear();
            sepetid.Clear();
            basketKontrol.Clear();
            SqlDataReader read = null;
            using (BasketDatabase bD = new BasketDatabase())
            {
                read = bD.BasketListKontrol();
                while (read.Read())
                {
                    basketKontrol.Add(Convert.ToInt32(read["UrunID"]));
                    sepetid.Add(Convert.ToInt32(read["SepetID"]));
                    tutar.Add(Convert.ToInt32(read["Tutar"]));
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
