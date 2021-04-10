using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace DatabaseLogicLayer
{
    public class InvoiceDatabase : DatabaseConnection
    {
        public int InvoiceAdd(Invoice invoice)
        {
            int resulReturn;
            cmd = new SqlCommand("insert into FaturaBilgi (Seri,SiraNo,Tarih,VergiDairesi,MusteriNo,Alici,AliciTel,AliciMail,TeslimEden,TeslimAlan,UrunId,OdenecekTutar) values (@Seri,@SiraNo,@Tarih,@VergiDairesi,@MusteriNo,@Alici,@AliciTel,@AliciMail,@TeslimEden,@TeslimAlan,@UrunId,@OdenecekTutar)", con);
            cmd.Parameters.Add("@SiraNo", SqlDbType.Char).Value = invoice.Seri;
            cmd.Parameters.Add("@Seri", SqlDbType.NVarChar).Value = invoice.SiraNo;
            cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = invoice.Tarih;
            cmd.Parameters.Add("@VergiDairesi", SqlDbType.NVarChar).Value = invoice.VergiDairesi;
            cmd.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = invoice.MusteriNo;
            cmd.Parameters.Add("@Alici", SqlDbType.NVarChar).Value = invoice.Alici;
            cmd.Parameters.Add("@AliciTel", SqlDbType.Char).Value = invoice.AliciTel;
            cmd.Parameters.Add("@AliciMail", SqlDbType.NVarChar).Value = invoice.AliciMail;
            cmd.Parameters.Add("@TeslimEden", SqlDbType.NVarChar).Value = invoice.TeslimEden;
            cmd.Parameters.Add("@TeslimAlan", SqlDbType.NVarChar).Value = invoice.TeslimAlan;
            cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = invoice.UrunId;
            cmd.Parameters.Add("@OdenecekTutar", SqlDbType.Decimal).Value = invoice.OdenecekTutar;
            ConnectionWizard();
            resulReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resulReturn;
        }
        public DataTable InvoiceList(DataGridView grid)
        {
            SqlDataAdapter da = new SqlDataAdapter("select FaturaBilgiID,Seri,SiraNo,Tarih,VergiDairesi,MusteriNo,Alici,AliciTel,AliciMail, TeslimEden, TeslimAlan, UrunAd, MarkaAd, UrunModel, OdenecekTutar from FaturaBilgi inner join Urunler on FaturaBilgi.UrunId = Urunler.UrunID left join UrunMarka on Urunler.UrunMarkaId = UrunMarka.MarkaID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            return dt;
        }
    }
}
