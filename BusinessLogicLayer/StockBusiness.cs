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
        public int StockAdd(string UrunId, short StokAdet)
        {
            int resulReturn = 0;
            using (StockDatabase sD = new StockDatabase())
            {
                if (UrunId == null) resulReturn = 0;
                else if (StokAdet < 0) resulReturn = 1;
                else
                {
                    Stock stock = new Stock()
                    {
                        UrunId = UrunId.ToString(),
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
    }
}
