using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DatabaseLogicLayer
{
    public class BanksDatabase : DatabaseConnection
    {
       public int BanksAdd(Banks banks)
        {
            int resultReturn;
            cmd = new SqlCommand("BankaEkle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BankaAdi", SqlDbType.NVarChar).Value = banks.BankaAdi;
            cmd.Parameters.Add("@Sube", SqlDbType.NVarChar).Value = banks.Sube;
            cmd.Parameters.Add("@Iban", SqlDbType.NVarChar).Value = banks.Iban;
            cmd.Parameters.Add("@HesapNo", SqlDbType.NVarChar).Value = banks.HesapNo;
            cmd.Parameters.Add("@Yetkili", SqlDbType.NVarChar).Value = banks.Yetkili;
            cmd.Parameters.Add("@Tarih", SqlDbType.NVarChar).Value = banks.Tarih;
            cmd.Parameters.Add("@HesapTur", SqlDbType.NVarChar).Value = banks.HesapTur;
            cmd.Parameters.Add("@FirmaId", SqlDbType.SmallInt).Value = banks.FirmaId;
            ConnectionWizard();
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public int BanksUpdate(Banks banks)
        {
            int resultReturn;
            cmd = new SqlCommand("BankaGuncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BankaID", SqlDbType.SmallInt).Value = banks.BankaID;
            cmd.Parameters.Add("@BankaAdi", SqlDbType.NVarChar).Value = banks.BankaAdi;
            cmd.Parameters.Add("@Sube", SqlDbType.NVarChar).Value = banks.Sube;
            cmd.Parameters.Add("@Iban", SqlDbType.NVarChar).Value = banks.Iban;
            cmd.Parameters.Add("@HesapNo", SqlDbType.NVarChar).Value = banks.HesapNo;
            cmd.Parameters.Add("@Yetkili", SqlDbType.NVarChar).Value = banks.Yetkili;
            cmd.Parameters.Add("@Tarih", SqlDbType.NVarChar).Value = banks.Tarih;
            cmd.Parameters.Add("@HesapTur", SqlDbType.NVarChar).Value = banks.HesapTur;
            cmd.Parameters.Add("@FirmaId", SqlDbType.SmallInt).Value = banks.FirmaId;
            ConnectionWizard();
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public int BanksDelete(short id)
        {
            int resultReturn;
            cmd = new SqlCommand("BankaSil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BankaID", SqlDbType.SmallInt).Value = id;
            ConnectionWizard();
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public SqlDataReader BanksList()
        {
            cmd = new SqlCommand("BankaListe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
