using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Basket
    {
        public int SepetID { get; set; }
        public string UrunAd { get; set; }
        public string MarkaAd { get; set; }
        public string UrunModel { get; set; }
        public short Adet { get; set; }
        public decimal Tutar { get; set; }
    }
}
