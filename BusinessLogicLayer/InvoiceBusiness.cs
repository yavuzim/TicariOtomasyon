using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLogicLayer;
using Entities;
using System.Windows.Forms;
namespace BusinessLogicLayer
{
    public class InvoiceBusiness
    {
        public int InvoiceAdd(string Seri, string SiraNo, DateTime Tarih, string VergiDairesi, int MusteriNo, string Alici, string AliciTel, string AliciMail, string TeslimEden, string TeslimAlan, int UrunId, decimal OdenecekTutar)
        {
            int resulReturn = 0;

            using (InvoiceDatabase iDa = new InvoiceDatabase())
            {
                if (Seri == "" || SiraNo == "" || Tarih == null || VergiDairesi == "" || MusteriNo < 0 || Alici == "" || AliciTel == "" || AliciMail == "" || TeslimEden == "" || TeslimAlan == "")
                    resulReturn = 1;
                else
                {
                    Invoice invoice = new Invoice()
                    {
                        Seri = Seri,
                        SiraNo = SiraNo,
                        Tarih = Tarih,
                        VergiDairesi = VergiDairesi,
                        MusteriNo = MusteriNo,
                        Alici = Alici,
                        AliciTel = AliciTel,
                        AliciMail = AliciMail,
                        TeslimEden = TeslimEden,
                        TeslimAlan = TeslimAlan,
                        UrunId = UrunId,
                        OdenecekTutar = OdenecekTutar
                    };
                    resulReturn = iDa.InvoiceAdd(invoice);
                    resulReturn = 2;

                }
            }
            return resulReturn;
        }
        public void InvoiceList(DataGridView grid)
        {
            List<Invoice> invoiceList = new List<Invoice>();
            DataTable dt = new DataTable();
            using (InvoiceDatabase iDa = new InvoiceDatabase())
            {
                dt = iDa.InvoiceList(grid);
            }
        }
    }
}
