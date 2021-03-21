using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Products
    {
        string _urunAd, _yil;
        decimal _alisFiyat, _satisFiyat, _kdv;
        int _indirim;
        public bool YilLength = true, AlisKontrol = true, SatisKontrol = true, IndirimKontrol = true, KdvKontrol = true, adetKontrol = true;
        public int UrunID
        {
            get;
            set;
        }
        public string UrunAd
        {
            get { return this._urunAd; }
            set
            {
                // Girilen ürün isminin ilk harfini büyük harfe çevirme.
                string letter = null;
                string[] gelenAd = new string[value.Length];
                for (int i = 0; i < gelenAd.Length; i++)
                {
                    gelenAd[i] = value[i].ToString();
                    if (gelenAd.Length - 1 == i)
                    {
                        letter = gelenAd[0].ToUpper();
                        Array.Clear(gelenAd, 0, 1);
                        for (int j = 0; j < gelenAd.Length; j++)
                        {
                            letter += gelenAd[j];
                        }
                    }
                }
                _urunAd = letter.Trim();
            }
        }
        public string UrunMarkaId
        {
            get;
            set;
        }
        public string UrunModel
        {
            get;
            set;
        }
        public string Yil
        {
            get { return this._yil; }
            set
            {
                if (value.Length == 4)
                    _yil = value.Trim();
                else YilLength = false;
            }
        }
        public decimal AlisFiyat
        {
            get { return this._alisFiyat; }
            set
            {
                if (value > 0) _alisFiyat = value;
                else AlisKontrol = false;
            }
        }
        public decimal SatisFiyat
        {
            get { return this._satisFiyat; }
            set
            {
                if (value > 0) _satisFiyat = value;
                else SatisKontrol = false;
            }
        }
        public int Indirim
        {
            get { return this._indirim; }
            set
            {
                if (value >= 0) _indirim = value;
                else IndirimKontrol = false;
            }
        }
        public decimal KDV
        {
            get { return this._kdv; }
            set
            {
                if (value >= 0) _kdv = value;
                else KdvKontrol = false;
            }
        }
        public string UrunDetay
        {
            get;
            set;
        }
        public bool Durum { get; set; }
    }
}
