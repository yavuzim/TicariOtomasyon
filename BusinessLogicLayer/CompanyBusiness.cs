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
        public int CompanyAdd(string FirmaAd, string YetkiliStatu, string YetkiliAdSoyad, string YetkiliTc, string Sektor, string Telefon1, string Telefon2, string Telefon3, string Email, string Fax, int SehirId, int IlceId, string VergiDairesi, string Adres, string OzelKod1, string OzelKod2, string OzelKod3)
        {
            int resultReturn = 0;
            using (CompanyDatabase cD = new CompanyDatabase())
            {
                Company company = new Company()
                {
                    FirmaAd = FirmaAd,
                    YetkiliStatu = YetkiliStatu,
                    YetkiliAdSoyad = YetkiliAdSoyad,
                    YetkiliTc = YetkiliTc,
                    Sektor = Sektor,
                    Telefon1 = Telefon1,
                    Telefon2 = Telefon2,
                    Telefon3 = Telefon3,
                    Email = Email,
                    Fax = Fax,
                    SehirId = SehirId.ToString(),
                    IlceId = IlceId.ToString(),
                    VergiDairesi = VergiDairesi,
                    Adres = Adres,
                    OzelKod1 = OzelKod1,
                    OzelKod2 = OzelKod2,
                    OzelKod3 = OzelKod3
                };
                resultReturn = cD.CompanyAdd(company);
            }
            return resultReturn;
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
