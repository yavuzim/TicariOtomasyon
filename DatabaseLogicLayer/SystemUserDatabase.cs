using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseLogicLayer
{
    public class SystemUserDatabase : DatabaseConnection
    {
        public SqlDataReader SystemLogin(SystemUser systemuser)
        {
            cmd = new System.Data.SqlClient.SqlCommand("Admin_Giris", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@KullaniciAd", SqlDbType.NVarChar).Value = systemuser.KullaniciAdi;
            cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = systemuser.Sifre;
            ConnectionWizard();
            reader = cmd.ExecuteReader(); 
            return reader;
        }
    }
}
