using DatabaseLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
namespace BusinessLogicLayer
{
    public class BasketBusiness
    {
        public int BasketAdd(int Urun, short Adet, decimal Tutar)
        {
            int resultReturn = 0;
            StockBusiness sBusiness = new StockBusiness();
            List<StockList> stockList = sBusiness.StockList();
            for (int i = 0; i < stockList.Count; i++)
             {
                 if (stockList[i].UrunID == Urun)
                 {
                     //kontrol = false;
                     break;
                 }
             }
            var numCount1 = stockList.Where(x => x.UrunID == Urun).Count();
            if (numCount1 == 1)
            {

            }
            else
            {
                using (BasketDatabase bD = new BasketDatabase())
                {
                    resultReturn = bD.BasketAdd(Urun, Adet, Tutar);
                    resultReturn = 2;
                }
            }
            numCount1 = 0;
            return resultReturn;
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
