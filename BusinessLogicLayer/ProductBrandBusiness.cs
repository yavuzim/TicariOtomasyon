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
    public class ProductBrandBusiness
    {
        public List<ProductBrand> BrandList()
        {
            List<ProductBrand> pbList = new List<ProductBrand>();
            using (ProductBrandDatabase brandDatabase = new ProductBrandDatabase())
            {
                SqlDataReader read = brandDatabase.BrandList();
                while (read.Read())
                {
                    ProductBrand pBrand = new ProductBrand();
                    pBrand.MarkaID = read.GetInt32(0);
                    pBrand.MarkaAd = read.GetString(1);
                    pbList.Add(pBrand);
                }
                read.Close();
                brandDatabase.ConnectionWizard();
            }
            return pbList;
        }
    }
}
