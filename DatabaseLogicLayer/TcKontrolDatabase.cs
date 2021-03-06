using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DatabaseLogicLayer
{
    public class TcKontrolDatabase : DatabaseConnection
    {
        public SqlDataReader TcList()
        {
            cmd = new SqlCommand("select TC from Musteriler", con);
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
        public SqlDataReader TcListCompany()
        {
            cmd = new SqlCommand("select YetkiliTc from Firmalar", con);
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
        public SqlDataReader TcListPersonnel()
        {
            cmd = new SqlCommand("select TC from Personeller", con);
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
