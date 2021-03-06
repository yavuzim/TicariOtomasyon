using Entities;
using System;
using System.Collections.Generic;
using System.Data;
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
            cmd.Parameters.Add("@Adres", SqlDbType.Int).Value = personnel.Adres;
            ConnectionWizard();
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
    }
}
