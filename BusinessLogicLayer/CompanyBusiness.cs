using DatabaseLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CompanyBusiness
    {
        public static int companyTC;
        public int CompanyAdd(string FirmaAd, string YetkiliStatu, string YetkiliAdSoyad, string YetkiliTc, string Sektor, string Telefon1, string Telefon2, string Telefon3, string Email, string Fax, int SehirId, int IlceId, string VergiDairesi, string Adres, string OzelKod1, string OzelKod2, string OzelKod3)
        {
            int resultReturn = 0;

            Company company = new Company();
            using (CompanyDatabase cD = new CompanyDatabase())
            {
                company.FirmaAd = FirmaAd;
                company.YetkiliStatu = YetkiliStatu;
                company.YetkiliAdSoyad = YetkiliAdSoyad;
                company.YetkiliTc = YetkiliTc;
                company.Sektor = Sektor;
                company.Telefon1 = Telefon1;
                company.Telefon2 = Telefon2;
                company.Telefon3 = Telefon3;
                company.Email = Email;
                company.Fax = Fax;
                company.SehirId = SehirId.ToString();
                company.IlceId = IlceId.ToString();
                company.VergiDairesi = VergiDairesi;
                company.Adres = Adres;
                company.OzelKod1 = OzelKod1;
                company.OzelKod2 = OzelKod2;
                company.OzelKod3 = OzelKod3;
                if (string.IsNullOrEmpty(company.FirmaAd) || string.IsNullOrEmpty(company.YetkiliStatu) || string.IsNullOrEmpty(company.YetkiliAdSoyad) || string.IsNullOrEmpty(company.YetkiliTc) || string.IsNullOrEmpty(company.Sektor) || string.IsNullOrEmpty(company.Telefon1) || string.IsNullOrEmpty(company.Email) || string.IsNullOrEmpty(company.Fax) || string.IsNullOrEmpty(company.VergiDairesi) || string.IsNullOrEmpty(company.Adres)) resultReturn = 0;
                else
                {
                    if (!company._tcLengthKontrol) resultReturn = 1;
                    else if (!company._telefon1Length || !company._telefon2Length || !company._telefon3Length) resultReturn = 2;
                    else
                    {
                        companyTC = 1;
                        TcKontrolBusiness tcKontrol = new TcKontrolBusiness();
                        bool kontrol = tcKontrol.TcListKontrol(YetkiliTc);
                        if (!kontrol) resultReturn = 3;
                        else
                        {
                            int x = cD.CompanyAdd(company);
                            if (x == 1) resultReturn = 4;
                        }
                    }
                }
            }
            return resultReturn;
        }
        public int CompanyUpdate(short FirmaID, string FirmaAd, string YetkiliStatu, string YetkiliAdSoyad, string YetkiliTc, string Sektor, string Telefon1, string Telefon2, string Telefon3, string Email, string Fax, int SehirId, int IlceId, string VergiDairesi, string Adres, string OzelKod1, string OzelKod2, string OzelKod3)
        {
            return 1;
        }

        public List<Company> CompanyList()
        {
            List<Company> companyList = new List<Company>();
            using (CompanyDatabase cD = new CompanyDatabase())
            {
                SqlDataReader read = cD.CompanyList();
                while (read.Read())
                {
                    Company company = new Company()
                    {
                        FirmaID = read.GetInt16(0),
                        FirmaAd = read.GetString(1),
                        YetkiliStatu = read.GetString(2),
                        YetkiliAdSoyad = read.GetString(3),
                        YetkiliTc = read.GetString(4),
                        Sektor = read.GetString(5),
                        Telefon1 = read.GetString(6),
                        Telefon2 = read.GetString(7),
                        Telefon3 = read.GetString(8),
                        Email = read.GetString(9),
                        Fax = read.GetString(10),
                        SehirId = read.GetString(11),
                        IlceId = read.GetString(12),
                        VergiDairesi = read.GetString(13),
                        Adres = read.GetString(14),
                        OzelKod1 = read.GetString(15),
                        OzelKod2 = read.GetString(16),
                        OzelKod3 = read.GetString(17),
                    };
                    companyList.Add(company);
                }
                read.Close();
            }
            return companyList;
        }
    }
}
