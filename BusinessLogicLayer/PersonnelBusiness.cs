using DatabaseLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class PersonnelBusiness
    {
        public static int personnelTC = 0;
        public int PersonnelAdd(string Ad, string Soyad, string Telefon, string TC, string Mail, int Sehir, int Ilce, string Adres, int GorevId)
        {
            int resultReturn = 0, getData = 0;
            if (string.IsNullOrEmpty(Ad) || string.IsNullOrEmpty(Soyad) || string.IsNullOrEmpty(Telefon) || string.IsNullOrEmpty(TC) || string.IsNullOrEmpty(Mail) || string.IsNullOrEmpty(Adres)) resultReturn = 0;
            else
            {
                personnelTC = 1;
                Personnel presonnel = new Personnel();
                TcKontrolBusiness tcB = new TcKontrolBusiness();
                using (PersonnelDatabase pD = new PersonnelDatabase())
                {
                    bool kontrol = tcB.TcListKontrol(TC);
                    if (kontrol)
                    {
                        presonnel.Ad = Ad;
                        presonnel.Soyad = Soyad;
                        presonnel.Telefon = Telefon;
                        presonnel.TC = TC;
                        presonnel.Mail = Mail;
                        presonnel.Sehir = Sehir.ToString();
                        presonnel.Ilce = Ilce.ToString();
                        presonnel.Adres = Adres;
                        presonnel.GorevId = GorevId.ToString();
                        if (!presonnel._telefonKontrol) resultReturn = 1;
                        else if (!presonnel._tcKontrol) resultReturn = 3;
                        else
                            getData = pD.PersonnelAdd(presonnel);

                        if (getData > 0) resultReturn = 4;
                    }
                    else resultReturn = -1;
                }
            }
            return resultReturn;
        }
    }
}
