using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DatabaseLogicLayer
{
    public class ProductDatabase : DatabaseConnection
    {
        public int ProductAdd(Products product)
        {
            cmd = new SqlCommand("UrunEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@UrunAd", System.Data.SqlDbType.NVarChar).Value = product.UrunAd;
            cmd.Parameters.Add("@UrunMarkaId", System.Data.SqlDbType.Int).Value = product.UrunMarkaId;
            cmd.Parameters.Add("@UrunModel", System.Data.SqlDbType.NVarChar).Value = product.UrunModel;
            cmd.Parameters.Add("@Yil", System.Data.SqlDbType.NVarChar).Value = product.Yil;
            cmd.Parameters.Add("@AlisFiyat", System.Data.SqlDbType.Decimal).Value = product.AlisFiyat;
            cmd.Parameters.Add("@SatisFiyat", System.Data.SqlDbType.Decimal).Value = product.SatisFiyat;
            cmd.Parameters.Add("@Indirim", System.Data.SqlDbType.Int).Value = product.Indirim;
            cmd.Parameters.Add("@KDV", System.Data.SqlDbType.Decimal).Value = product.KDV;
            cmd.Parameters.Add("@UrunDetay", System.Data.SqlDbType.NVarChar).Value = product.UrunDetay;
            cmd.Parameters.Add("@Durum", System.Data.SqlDbType.Bit).Value = 0;
            ConnectionWizard();
            int resultReturn = cmd.ExecuteNonQuery();
            con.Close();
            return resultReturn;
        }
        public int ProductUpdate(Products product)
        {            
            cmd = new SqlCommand("UrunGuncelle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@UrunID", System.Data.SqlDbType.Int).Value = product.UrunID;
            cmd.Parameters.Add("@UrunAd", System.Data.SqlDbType.NVarChar).Value = product.UrunAd;
            cmd.Parameters.Add("@UrunMarkaId", System.Data.SqlDbType.Int).Value = product.UrunMarkaId;
            cmd.Parameters.Add("@UrunModel", System.Data.SqlDbType.NVarChar).Value = product.UrunModel;
            cmd.Parameters.Add("@Yil", System.Data.SqlDbType.NVarChar).Value = product.Yil;
            cmd.Parameters.Add("@AlisFiyat", System.Data.SqlDbType.Decimal).Value = product.AlisFiyat;
            cmd.Parameters.Add("@SatisFiyat", System.Data.SqlDbType.Decimal).Value = product.SatisFiyat;
            cmd.Parameters.Add("@Indirim", System.Data.SqlDbType.Int).Value = product.Indirim;
            cmd.Parameters.Add("@KDV", System.Data.SqlDbType.Decimal).Value = product.KDV;
            cmd.Parameters.Add("@UrunDetay", System.Data.SqlDbType.NVarChar).Value = product.UrunDetay;
            ConnectionWizard();
            int resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public int ProductBitUpdate(int id,byte _bit)
        {
            cmd = new SqlCommand("UrunDurumGuncelle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@UrunID", System.Data.SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Durum", System.Data.SqlDbType.Bit).Value = _bit;
            ConnectionWizard();
            int resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public SqlDataReader ProductList()
        {
            cmd = new SqlCommand("UrunListele", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
        public SqlDataReader ProductListId(int id)
        {
            cmd = new SqlCommand("UrunListeleId", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@UrunID", System.Data.SqlDbType.Int).Value = id;
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
