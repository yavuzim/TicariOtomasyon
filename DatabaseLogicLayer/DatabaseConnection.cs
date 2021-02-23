using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLayer
{
    public class DatabaseConnection : IDisposable
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader reader;

        public DatabaseConnection()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-J0U78C1\SQLEXPRESS;Initial Catalog=TicariOtomasyon;Integrated Security=True");
        }
        public void ConnectionWizard()
        {
            if (con.State == System.Data.ConnectionState.Closed) con.Open();
            else con.Close();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
