using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DatabaseLogicLayer
{
    public class BasketDatabase : DatabaseConnection
    {
        public SqlDataReader BasketList()
        {
            cmd = new SqlCommand("select SepetID,MusteriAdi,MusteriSoyad,UrunAd,MarkaAd,UrunModel,Adet,Tutar from Sepet inner join Urunler on Sepet.Urun = Urunler.UrunID left join UrunMarka on Urunler.UrunMarkaId = UrunMarka.MarkaID", con);
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
