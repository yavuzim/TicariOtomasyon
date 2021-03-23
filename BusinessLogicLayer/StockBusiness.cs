using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLogicLayer;
using Entities;
namespace BusinessLogicLayer
{
    public class StockBusiness
    {
        public int StockAdd(string UrunId, int StokAdet)
        {
            int resulReturn = 0;
            using (StockDatabase sD = new StockDatabase())
            {
                if (UrunId == null) resulReturn = 0;
                else if (StokAdet < 0) resulReturn = 1;
                else
                {
                    StockList stock = new StockList()
                    {
                        UrunAd = UrunId.ToString(),
                        StokAdet = StokAdet
                    };
                    resulReturn = sD.StockAdd(stock);
                    resulReturn = 2;
                }
            }
            if (resulReturn == 2)
            {
                Products product = new Products();
                List<Products> productsList = new List<Products>();
                using (ProductDatabase pD = new ProductDatabase())
                {
                    pD.ProductBitUpdate(int.Parse(UrunId), 1);
                }
            }
            return resulReturn;
        }
        public int StockUpdate(int id, int UrunId, int StokAdet)
        {
            int resulReturn = 0;
            using (StockDatabase sD = new StockDatabase())
            {
                if (UrunId == null) resulReturn = 0;
                else if (StokAdet < 0) resulReturn = 1;
                else
                {
                    StockList stock = new StockList()
                    {
                        StockID = id,
                        UrunAd = UrunId.ToString(),
                        StokAdet = StokAdet
                    };
                    resulReturn = sD.StockUpdate(stock);
                    resulReturn = 2;
                }
            }
            return resulReturn;
        }
        public List<StockList> StockList()
        {
            List<StockList> stockList = new List<StockList>();
            SqlDataReader read = null; StockList stock;
            using (StockDatabase sD = new StockDatabase())
            {
                read = sD.StockList();
                while (read.Read())
                {
                    stock = new StockList();
                    stock.UrunID = read.GetInt32(0);
                    stock.StockID = read.GetInt32(1);
                    stock.UrunAd = read.GetString(2).ToString();
                    stock.UrunMarkaId = read.GetString(3);
                    stock.UrunModel = read.GetString(4);
                    stock.UrunDetay = read.GetString(5);
                    stock.StokAdet = read.GetInt16(6);
                    stock.SatisFiyat = read.GetDecimal(7);
                    stock.Indirim = read.GetInt32(8);
                    stock.KDV = read.GetDecimal(9);
                    stockList.Add(stock);
                }
                read.Close();
            }
            return stockList;
        }
    }
}
