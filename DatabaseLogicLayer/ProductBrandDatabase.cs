using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;

namespace DatabaseLogicLayer
{
    public class ProductBrandDatabase : DatabaseConnection
    {
        public SqlDataReader BrandList()
        {
            cmd = new SqlCommand("select * from UrunMarka", con);
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
