using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public  class Invoice
    {
        public int FaturaBilgiID { get; set; }
        public string Seri { get; set; }
        public string SiraNo { get; set; }
        public DateTime Tarih { get; set; }
        public string VergiDairesi { get; set; }
        public int MusteriNo { get; set; }
        public string Alici { get; set; }
        public string AliciTel { get; set; }
        public string AliciMail { get; set; }
        public string TeslimEden { get; set; }
        public string TeslimAlan { get; set; }
        public int UrunId { get; set; }
        public decimal OdenecekTutar { get; set; }
    }
}
