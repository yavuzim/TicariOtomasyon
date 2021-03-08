using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLayer
{
    public class PersonnelDatabase : DatabaseConnection
    {
        public int PersonnelAdd(Personnel personnel)
        {
            int resultReturn;
            cmd = new System.Data.SqlClient.SqlCommand("PersonelEkle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PersonelAd", SqlDbType.NVarChar).Value = personnel.Ad;
            cmd.Parameters.Add("@PersonelSoyad", SqlDbType.NVarChar).Value = personnel.Soyad;
            cmd.Parameters.Add("@Telefon1", SqlDbType.NVarChar).Value = personnel.Telefon;
            cmd.Parameters.Add("@TC", SqlDbType.Char).Value = personnel.TC;
            cmd.Parameters.Add("@Mail", SqlDbType.NVarChar).Value = personnel.Mail;
            cmd.Parameters.Add("@SehirId", SqlDbType.Int).Value = personnel.Sehir;
            cmd.Parameters.Add("@IlceId", SqlDbType.Int).Value = personnel.Ilce;
            cmd.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = personnel.Adres;
            cmd.Parameters.Add("@GorevId", SqlDbType.Int).Value = personnel.GorevId;
            ConnectionWizard();
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public int PersonnelUpdate(Personnel personnel)
        {
            int resultReturn;
            cmd = new System.Data.SqlClient.SqlCommand("PersonelGuncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PersonelID", SqlDbType.NVarChar).Value = personnel.ID;
            cmd.Parameters.Add("@PersonelAd", SqlDbType.NVarChar).Value = personnel.Ad;
            cmd.Parameters.Add("@PersonelSoyad", SqlDbType.NVarChar).Value = personnel.Soyad;
            cmd.Parameters.Add("@Telefon1", SqlDbType.NVarChar).Value = personnel.Telefon;
            cmd.Parameters.Add("@TC", SqlDbType.Char).Value = personnel.TC;
            cmd.Parameters.Add("@Mail", SqlDbType.NVarChar).Value = personnel.Mail;
            cmd.Parameters.Add("@SehirId", SqlDbType.Int).Value = personnel.Sehir;
            cmd.Parameters.Add("@IlceId", SqlDbType.Int).Value = personnel.Ilce;
            cmd.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = personnel.Adres;
            cmd.Parameters.Add("@GorevId", SqlDbType.Int).Value = personnel.GorevId;
            ConnectionWizard();
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public int PersonnelDelete(int id)
        {
            int resultReturn;
            cmd = new System.Data.SqlClient.SqlCommand("PersonelSil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            ConnectionWizard();
            cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = id;
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public DataTable PersonnelList()
        {
            cmd = new SqlCommand("PersonelListe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
