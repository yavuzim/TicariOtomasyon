using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductBrand
    {
        public int MarkaID { get; set; }
        public string MarkaAd { get; set; }
        public override string ToString()
        {
            return MarkaAd;
        }
    }
}
