using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
namespace DatabaseLogicLayer
{
    public class StockDatabase : DatabaseConnection
    {
        public int StockAdd(StockList stock)
        {
            int resulReturn = 0;
            cmd = new SqlCommand("StokEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@UrunId", System.Data.SqlDbType.Int).Value = stock.UrunAd;
            cmd.Parameters.Add("@StokAdet", System.Data.SqlDbType.SmallInt).Value = stock.StokAdet;
            ConnectionWizard();
            resulReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resulReturn;
        }
        public int StockUpdate(StockList stock)
        {
            int resulReturn = 0;
            cmd = new SqlCommand("StokGuncelle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@StokID", System.Data.SqlDbType.Int).Value = stock.StockID;
            cmd.Parameters.Add("@UrunId", System.Data.SqlDbType.Int).Value = stock.UrunAd;
            cmd.Parameters.Add("@StokAdet", System.Data.SqlDbType.SmallInt).Value = stock.StokAdet;
            ConnectionWizard();
            resulReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resulReturn;
        }
        public SqlDataReader StockList()
        {
            cmd = new SqlCommand("select Urunler.UrunID,Stoklar.StokID,UrunAd,MarkaAd,UrunModel,UrunDetay,StokAdet,SatisFiyat,Indirim,KDV from Urunler inner join urunmarka on urunler.urunMarkaId = urunmarka.MarkaID left join Stoklar on Stoklar.UrunId = Urunler.UrunID where StokAdet!=''", con);
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
