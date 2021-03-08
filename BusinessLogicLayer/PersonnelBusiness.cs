using DatabaseLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BusinessLogicLayer
{
    public class PersonnelBusiness
    {
        public static int personnelTC = 0;
        public int PersonnelAdd(string Ad, string Soyad, string Telefon, string TC, string Mail, int Sehir, int Ilce, int GorevId, string Adres)
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
        public int PersonnelUpdate(int ID, string Ad, string Soyad, string Telefon, string TC, string _TC, string Mail, int Sehir, int Ilce, int GorevId, string Adres)
        {
            int resultReturn = 0, getData = 0;
            if (string.IsNullOrEmpty(Ad) || string.IsNullOrEmpty(Soyad) || string.IsNullOrEmpty(Telefon) || string.IsNullOrEmpty(TC) || string.IsNullOrEmpty(Mail) || string.IsNullOrEmpty(Adres)) resultReturn = 0;
            else
            {
                personnelTC = 1;
                Personnel personnel = new Personnel();
                TcKontrolBusiness tcB = new TcKontrolBusiness();
                using (PersonnelDatabase pdb = new PersonnelDatabase())
                {
                    tcB.TcListKontrol2(_TC);
                    bool kontrol = tcB.TcListKontrol(TC);
                    if (kontrol)
                    {
                        personnel.ID = ID;
                        personnel.Ad = Ad;
                        personnel.Soyad = Soyad;
                        personnel.Telefon = Telefon;
                        personnel.TC = TC;
                        personnel.Mail = Mail;
                        personnel.Sehir = Sehir.ToString();
                        personnel.Ilce = Ilce.ToString();
                        personnel.GorevId = GorevId.ToString();
                        personnel.Adres = Adres;
                        if (!personnel._telefonKontrol) resultReturn = 1;
                        else if (!personnel._tcKontrol) resultReturn = 3;
                        else
                            getData = pdb.PersonnelUpdate(personnel);
                        if (getData > 0) resultReturn = 4;
                    }
                    else resultReturn = -1;
                    personnelTC = 0;
                }
            }
            return resultReturn;
        }
        public int PersonnelDelete(int id)
        {
            int resultReturn = 0;
            using (PersonnelDatabase pD = new PersonnelDatabase())
            {
                resultReturn = pD.PersonnelDelete(id);
            }
            return resultReturn;
        }
        public void PersonnelList(DataGridView dG)
        {
            DataTable dt = null;
            using (PersonnelDatabase pD = new PersonnelDatabase())
            {
                dt = pD.PersonnelList();
                dG.DataSource = dt;
            }
        }
    }
}
