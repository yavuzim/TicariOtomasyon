using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;
namespace DatabaseLogicLayer
{
    public class BasketDatabase : DatabaseConnection
    {
        public int BasketAdd(int Urun,short Adet,decimal Tutar)
        {
            int resultReturn;
            cmd = new SqlCommand("insert into Sepet (Urun,Adet,Tutar) values (@Urun,@Adet,@Tutar)", con);
            cmd.Parameters.Add("@Urun", SqlDbType.Int).Value = Urun;
            cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = Adet;
            cmd.Parameters.Add("@Tutar", SqlDbType.Int).Value = Tutar;
            ConnectionWizard();
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public int BasketUpdate(int id,int adet)
        {
            int resultReturn;
            cmd = new SqlCommand("Update Sepet set Adet=@Adet where SepetID=@id", con);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = adet;
            ConnectionWizard();
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }

        public SqlDataReader BasketList()
        {
            cmd = new SqlCommand("select SepetID,UrunAd,MarkaAd,UrunModel,SatisFiyat,Adet,Tutar from Sepet inner join Urunler on Sepet.Urun = Urunler.UrunID left join UrunMarka on Urunler.UrunMarkaId = UrunMarka.MarkaID", con);
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
