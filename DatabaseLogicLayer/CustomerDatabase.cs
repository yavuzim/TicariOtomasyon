using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entities;
using System.Data.SqlClient;
namespace DatabaseLogicLayer
{
    public class CustomerDatabase : DatabaseConnection
    {
        public int CustomerAdd(Customer customer)
        {
            int resultReturn;
            cmd = new System.Data.SqlClient.SqlCommand("MusteriEkle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MusteriAd", SqlDbType.NVarChar).Value = customer.Ad;
            cmd.Parameters.Add("@MusteriSoyad", SqlDbType.NVarChar).Value = customer.Soyad;
            cmd.Parameters.Add("@Telefon1", SqlDbType.NVarChar).Value = customer.Telefon;
            cmd.Parameters.Add("@Telefon2", SqlDbType.NVarChar).Value = customer.Telefon2;
            cmd.Parameters.Add("@TC", SqlDbType.Char).Value = customer.TC;
            cmd.Parameters.Add("@Mail", SqlDbType.NVarChar).Value = customer.Mail;
            cmd.Parameters.Add("@SehirId", SqlDbType.Int).Value = customer.Sehir;
            cmd.Parameters.Add("@IlceId", SqlDbType.Int).Value = customer.Ilce;
            cmd.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = customer.Adres;
            cmd.Parameters.Add("@VergiDairesi", SqlDbType.NVarChar).Value = customer.VergiDairesi;
            ConnectionWizard();
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public int CustomerUpdate(Customer customer)
        {
            int resultReturn;
            cmd = new SqlCommand("MusteriGuncelle", con);
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.Parameters.Add("@MusteriID", SqlDbType.NVarChar).Value = customer.ID;
            cmd.Parameters.Add("@MusteriAd", SqlDbType.NVarChar).Value = customer.Ad;
            cmd.Parameters.Add("@MusteriSoyad", SqlDbType.NVarChar).Value = customer.Soyad;
            cmd.Parameters.Add("@Telefon1", SqlDbType.NVarChar).Value = customer.Telefon;
            cmd.Parameters.Add("@Telefon2", SqlDbType.NVarChar).Value = customer.Telefon2;
            cmd.Parameters.Add("@TC", SqlDbType.Char).Value = customer.TC;
            cmd.Parameters.Add("@Mail", SqlDbType.NVarChar).Value = customer.Mail;
            cmd.Parameters.Add("@SehirId", SqlDbType.Int).Value = customer.Sehir;
            cmd.Parameters.Add("@IlceId", SqlDbType.Int).Value = customer.Ilce;
            cmd.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = customer.Adres;
            cmd.Parameters.Add("@VergiDairesi", SqlDbType.NVarChar).Value = customer.VergiDairesi;
            ConnectionWizard();
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        // delete
        public DataTable CustomerList()
        {
            cmd = new SqlCommand("MusteriListe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
