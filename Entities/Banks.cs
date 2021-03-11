using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Banks
    {
        string _hesapNo, _yetkili;
        public bool hesapNoNumber = true, yetkiliNumber = true;
        public short BankaID { get; set; }
        public string BankaAdi { get; set; }
        public string Sube { get; set; }
        public string Iban { get; set; }
        public string HesapNo
        {
            get { return _hesapNo; }
            set
            {
                int numberCount = value.Where(i => char.IsNumber(i)).Count();
                if (numberCount == 0) hesapNoNumber = false;
                else _hesapNo = value.Trim();
            }
        }
        public string Yetkili
        {
            get { return _yetkili; }
            set
            {
                int numberCount = value.Where(i => char.IsNumber(i)).Count();
                if (numberCount == 0) _yetkili = value.Trim(); 
                else yetkiliNumber = false;
            }
        }
        public DateTime Tarih { get; set; }
        public string HesapTur { get; set; }
        public string FirmaId { get; set; }
    }
}
