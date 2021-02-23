using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CustomerPersonnelBaseType
    {
        string _ad, _soyad, _telefon, _mail, _adres, _tc;
        public bool _telefonKontrol = true, _tcKontrol = true;
        public int ID
        {
            get;
            set;
        }
        public string Ad
        {
            get { return _ad; }
            set { this._ad = value.Trim(); }
        }
        public string Soyad
        {
            get { return _soyad; }
            set { this._soyad = value.ToUpper().Trim(); }
        }
        public string Telefon
        {
            get { return _telefon; }
            set
            {
                if (value.Length == 11)
                    this._telefon = value.Trim();
                else _telefonKontrol = false;
            }
        }
        public string TC
        {
            get { return _tc; }
            set
            {
                
                if (value.Length == 11)
                {
                    this._tc = value.Trim();
                }
                else _tcKontrol = false;
            }
        }
        public string Mail
        {
            get { return this._mail; }
            set { this._mail = value.Trim(); }
        }
        public string Sehir
        {
            get;
            set;
        }
        public string Ilce
        {
            get;
            set;
        }
        public string Adres
        {
            get { return this._adres; }
            set { this._adres = value.Trim(); }
        }
    }

}
