using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer : CustomerPersonnelBaseType
    {
        string _telefon2, _vergiDairesi;
        public bool _telefonKontrol2 = true;
        public string Telefon2
        {
            get { return _telefon2; }
            set
            {
                if (value.Length == 11)
                    this._telefon2 = value.Trim();
                else if(value.Length==0)
                    this._telefon2 = value.Trim();
                else _telefonKontrol2 = false;
            }
        }
        public string VergiDairesi
        {
            get { return this._vergiDairesi; }
            set { this._vergiDairesi = value.Trim(); }
        }
    }
}
