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
        public SqlDataReader StockList()
        {
            cmd = new SqlCommand("select Stoklar.StokID,UrunAd,UrunMarkaId,UrunModel,UrunDetay,StokAdet from Stoklar inner join Urunler on Stoklar.UrunId = Urunler.UrunID ", con);
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
