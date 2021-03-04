using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Company
    {
        string _firmaAd, _YetkiliStatu, _YetkiliAdSoyad, _tc, _sektor, _telefon1, _telefon2, _telefon3, _email, _fax, _vergiDairesi, _adres;
        public bool _tcLengthKontrol = true, _telefon1Length = true, _telefon2Length = true, _telefon3Length = true;
        public short FirmaID { get; set; }
        public string FirmaAd
        {
            get { return this._firmaAd; }
            set
            {
                _firmaAd = value.Trim().ToUpper();
            }
        }
        public string YetkiliStatu
        {
            get { return this._YetkiliStatu; }
            set
            {
                _YetkiliStatu = value.Trim().ToUpper();
            }
        }
        public string YetkiliAdSoyad
        {
            get { return this._YetkiliAdSoyad; }
            set
            {
                _YetkiliAdSoyad = value.Trim().ToUpper();
            }
        }
        public string YetkiliTc
        {
            get { return this._tc; }
            set
            {
                if (value.Length == 11) _tc = value.Trim();
                else if (value.Length == 0) _tc = value.Trim();
                else
                {
                    _tcLengthKontrol = false;
                    _tc = value.Trim();
                }
            }
        }
        public string Sektor
        {
            get { return this._sektor; }
            set
            {
                _sektor = value.Trim().ToUpper();
            }
        }
        public string Telefon1
        {
            get { return this._telefon1; }
            set
            {
                if (value.Length == 11) _telefon1 = value.Trim();
                else if (value.Length == 0)
                    this._telefon1 = value.Trim();
                else
                {
                    _telefon1 = value.Trim();
                    _telefon1Length = false;
                }
            }
        }
        public string Telefon2
        {
            get { return this._telefon2; }
            set
            {
                if (value.Length == 11) _telefon2 = value.Trim();
                else if (value.Length == 0)
                    this._telefon2 = value.Trim();
                else _telefon2Length = false;
            }
        }
        public string Telefon3
        {
            get { return this._telefon3; }
            set
            {
                if (value.Length == 11) _telefon3 = value.Trim();
                else if (value.Length == 0)
                    this._telefon3 = value.Trim();
                else _telefon3Length = false;
            }
        }
        public string Email
        {
            get { return this._email; }
            set
            {
                _email = value.Trim();
            }
        }
        public string Fax
        {
            get { return this._fax; }
            set { _fax = value.Trim().ToUpper(); }
        }
        public string SehirId { get; set; }
        public string IlceId { get; set; }
        public string VergiDairesi
        {
            get { return this._vergiDairesi; }
            set { _vergiDairesi = value.Trim().ToUpper(); }
        }
        public string Adres
        {
            get { return this._adres; }
            set { _adres = value.Trim().ToUpper(); }
        }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
    }
}
