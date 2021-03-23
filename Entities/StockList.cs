using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StockList
    {
        public int UrunID { get; set; }
        public int StockID { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarkaId { get; set; }
        public string UrunModel { get; set; }
        public string UrunDetay { get; set; }
        public int StokAdet { get; set; }
        public decimal SatisFiyat { get; set; }
        public int Indirim { get; set; }
        public decimal KDV { get; set; }
    }
}
