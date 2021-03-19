using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DatabaseLogicLayer;
using System.Data.SqlClient;
namespace BusinessLogicLayer
{
    public class ProductBusiness
    {
        public int ProductAdd(string UrunAd, int UrunMarkaId, string UrunModel, string Yil, decimal AlisFiyat, decimal SatisFiyat, int Indirim, decimal KDV, string UrunDetay)
        {
            int resultReturn = 0;
            Products product = new Products();
            if (string.IsNullOrEmpty(UrunAd) || string.IsNullOrEmpty(UrunModel) || string.IsNullOrEmpty(Yil) || string.IsNullOrEmpty(UrunDetay)) resultReturn = -1;
            else
            {
                product.UrunAd = UrunAd;
                product.UrunMarkaId = UrunMarkaId.ToString();
                product.UrunModel = UrunModel;
                product.Yil = Yil;
                product.AlisFiyat = AlisFiyat;
                product.SatisFiyat = SatisFiyat;
                product.Indirim = Indirim;
                product.KDV = KDV;
                product.UrunDetay = UrunDetay;
                if (product.YilLength == false) resultReturn = 0;
                else if (product.AlisKontrol == false || product.SatisKontrol == false) resultReturn = 1;
                else if (product.IndirimKontrol == false) resultReturn = 2;
                else if (product.KdvKontrol == false) resultReturn = 3;
                else
                {
                    using (ProductDatabase productDatabase = new ProductDatabase())
                    {
                        int getExecute = productDatabase.ProductAdd(product);
                        resultReturn = 4;
                    }
                }
            }
            return resultReturn;
        }
        public int ProductUpdate(int UrunId, string UrunAd, int UrunMarkaId, string UrunModel, string Yil, decimal AlisFiyat, decimal SatisFiyat, int Indirim, decimal KDV, string UrunDetay)
        {
            int resultReturn;
            using (ProductDatabase pDal = new ProductDatabase())
            {
                resultReturn = pDal.ProductUpdate(new Products()
                {
                    UrunID = UrunId,
                    UrunAd = UrunAd,
                    UrunMarkaId = UrunMarkaId.ToString(),
                    UrunModel = UrunModel,
                    Yil = Yil,
                    AlisFiyat = AlisFiyat,
                    SatisFiyat = SatisFiyat,
                    Indirim = Indirim,
                    KDV = KDV,
                    UrunDetay = UrunDetay
                });
            }
            if (new Products().YilLength == false) resultReturn = 0;
            else if (new Products().AlisKontrol == false || new Products().SatisKontrol == false) resultReturn = 1;
            else if (new Products().IndirimKontrol == false) resultReturn = 2;
            else if (new Products().KdvKontrol == false) resultReturn = 3;
            else resultReturn = 4;
            return resultReturn;
        }
        public int ProductDelete(int id)
        {
            return 1;
        }

        public List<Products> ProductList()
        {
            SqlDataReader read = null;
            List<Products> productList = new List<Products>();
            using (ProductDatabase dll = new ProductDatabase())
            {
                read = dll.ProductList();
                while (read.Read())
                {
                    Products product = new Products();
                    product.UrunID = read.GetInt32(0);
                    product.UrunAd = read.GetString(1);
                    product.UrunMarkaId = read.GetString(2);
                    product.UrunModel = read.GetString(3);
                    product.Yil = read.GetString(4);
                    product.AlisFiyat = read.GetDecimal(5);
                    product.SatisFiyat = read.GetDecimal(6);
                    product.Indirim = read.GetInt32(7);
                    product.KDV = read.GetDecimal(8);
                    product.UrunDetay = read.GetString(9);
                    product.Durum = read.GetBoolean(10);
                    productList.Add(product);
                }
            }
            read.Close();
            return productList;
        }
        //public List<Products> ProductListId(int id)
        //{
        //    SqlDataReader read = null;
        //    List<Products> productList = new List<Products>();
        //    using (ProductDatabase dll = new ProductDatabase())
        //    {
        //        read = dll.ProductList();
        //        while (read.Read())
        //        {
        //            Products product = new Products();
        //            product.UrunID = read.GetInt32(0);
        //            product.UrunAd = read.GetString(1);
        //            product.UrunMarkaId = read.GetString(2);
        //            product.UrunModel = read.GetString(3);
        //            product.Yil = read.GetString(4);
        //            product.AlisFiyat = read.GetDecimal(5);
        //            product.SatisFiyat = read.GetDecimal(6);
        //            product.Indirim = read.GetInt32(7);
        //            product.KDV = read.GetDecimal(8);
        //            product.UrunDetay = read.GetString(9);
        //            product.Durum = read.GetBoolean(10);
        //            productList.Add(product);
        //        }
        //    }
        //    read.Close();
        //    return productList;
        //}
    }
}
