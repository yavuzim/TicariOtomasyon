using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DatabaseLogicLayer
{
    public class BrandDatabase : DatabaseConnection
    {
        public SqlDataReader BrandList()
        {
            cmd = new SqlCommand("Select * from UrunMarka", con);
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
