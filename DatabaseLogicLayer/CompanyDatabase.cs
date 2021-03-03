using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;
using System.Data;
namespace DatabaseLogicLayer
{
    public class CompanyDatabase : DatabaseConnection
    {
        public int CompanyAdd(Company company)
        {
            int resultReturn = 0;
            cmd = new SqlCommand("FirmaEkle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FirmaAd", SqlDbType.NVarChar).Value = company.FirmaAd;
            cmd.Parameters.Add("@YetkiliStatu", SqlDbType.NVarChar).Value = company.YetkiliStatu;
            cmd.Parameters.Add("@YetkiliAdSoyad", SqlDbType.NVarChar).Value = company.YetkiliAdSoyad;
            cmd.Parameters.Add("@YetkiliTc", SqlDbType.NVarChar).Value = company.YetkiliTc;
            cmd.Parameters.Add("@Sektor", SqlDbType.NVarChar).Value = company.Sektor;
            cmd.Parameters.Add("@Telefon1", SqlDbType.NVarChar).Value = company.Telefon1;
            cmd.Parameters.Add("@Telefon2", SqlDbType.NVarChar).Value = company.Telefon2;
            cmd.Parameters.Add("@Telefon3", SqlDbType.NVarChar).Value = company.Telefon3;
            cmd.Parameters.Add("@EMail", SqlDbType.NVarChar).Value = company.Email;
            cmd.Parameters.Add("@Fax", SqlDbType.NVarChar).Value = company.Fax;
            cmd.Parameters.Add("@SehirId", SqlDbType.Int).Value = company.SehirId;
            cmd.Parameters.Add("@IlceId", SqlDbType.Int).Value = company.IlceId;
            cmd.Parameters.Add("@VergiDairesi", SqlDbType.NVarChar).Value = company.VergiDairesi;
            cmd.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = company.Adres;
            cmd.Parameters.Add("@OzelKod1", SqlDbType.NVarChar).Value = company.OzelKod1;
            cmd.Parameters.Add("@OzelKod2", SqlDbType.NVarChar).Value = company.OzelKod2;
            cmd.Parameters.Add("@OzelKod3", SqlDbType.NVarChar).Value = company.OzelKod3;
            ConnectionWizard();
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public SqlDataReader CompanyList()
        {
            cmd = new SqlCommand("FirmaListe", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
