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
    public class BrandBusiness
    {
        public List<Brand> BrandList()
        {
            List<Brand> brandList = new List<Brand>();
            SqlDataReader read = null; Brand brand;
            using (BrandDatabase bD = new BrandDatabase())
            {
                read = bD.BrandList();
                while (read.Read())
                {
                    brand = new Brand()
                    {
                        MarkaID = read.GetInt32(0),
                        MarkaAd = read.GetString(1)
                    };
                    brandList.Add(brand);
                }
                read.Close();
            }
            return brandList;
        }
    }
}
