using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Debt
    {
        string _yil;
       public bool _yilLength = true;
        public int GiderID { get; set; }
        public string Ay { get; set; }
        public string Yil
        {
            get { return this._yil; }
            set
            {
                if (value.Length == 4) _yil = value;
                else _yilLength = false;
            }
        }
        public decimal Elektrik { get; set; }
        public decimal Su { get; set; }
        public decimal Dogalgaz { get; set; }
        public decimal Internet { get; set; }
        public decimal Maaslar { get; set; }
        public decimal Ekstra { get; set; }
        public string Notlar { get; set; }
    }
}
