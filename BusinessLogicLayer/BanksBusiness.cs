using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DatabaseLogicLayer;
using System.Data.SqlClient;
namespace BusinessLogicLayer
{
    public class BanksBusiness
    {
        public int BanksAdd(string BankaAdi, string Sube, string Iban, string HesapNo, string Yetkili, DateTime Tarih, string HesapTur, int FirmaId)
        {
            int resultReturn = 0;
            using (BanksDatabase bD = new BanksDatabase())
            {
                Banks banks = new Banks()
                {
                    BankaAdi = BankaAdi,
                    Sube = Sube,
                    Iban = Iban,
                    HesapNo = HesapNo,
                    Yetkili = Yetkili,
                    Tarih = Tarih,
                    HesapTur = HesapTur,
                    FirmaId = FirmaId.ToString()
                };
                if(!banks.hesapNoNumber) resultReturn = 0;
                if (!banks.yetkiliNumber) resultReturn = 1;
                if(banks.hesapNoNumber && banks.yetkiliNumber)
                {
                    if (string.IsNullOrEmpty(banks.BankaAdi) || string.IsNullOrEmpty(banks.Sube) || string.IsNullOrEmpty(banks.Iban) || string.IsNullOrEmpty(banks.HesapNo) || string.IsNullOrEmpty(HesapTur)) resultReturn = 2;
                    else
                    {
                        resultReturn = bD.BanksAdd(banks);
                        resultReturn = 3;
                    }
                }
            }
            return resultReturn;
        }

        public int BanksUpdate(short BankaID,string BankaAdi, string Sube, string Iban, string HesapNo, string Yetkili, DateTime Tarih, string HesapTur, int FirmaId)
        {
            int resultReturn = 0;
            using (BanksDatabase bD = new BanksDatabase())
            {
                Banks banks = new Banks()
                {
                    BankaID=BankaID,
                    BankaAdi = BankaAdi,
                    Sube = Sube,
                    Iban = Iban,
                    HesapNo = HesapNo,
                    Yetkili = Yetkili,
                    Tarih = Tarih,
                    HesapTur = HesapTur,
                    FirmaId = FirmaId.ToString()
                };
                if (!banks.hesapNoNumber) resultReturn = 0;
                if (!banks.yetkiliNumber) resultReturn = 1;
                if (banks.hesapNoNumber && banks.yetkiliNumber)
                {
                    if (string.IsNullOrEmpty(banks.BankaAdi) || string.IsNullOrEmpty(banks.Sube) || string.IsNullOrEmpty(banks.Iban) || string.IsNullOrEmpty(banks.HesapNo) || string.IsNullOrEmpty(HesapTur)) resultReturn = 2;
                    else
                    {
                        resultReturn = bD.BanksUpdate(banks);
                        resultReturn = 3;
                    }
                }
            }
            return resultReturn;
        }
        public int BanksDelete(short id)
        {
            int resultReturn = 0;
            using (BanksDatabase bD = new BanksDatabase())
            {
                resultReturn = bD.BanksDelete(id);
            }
            return resultReturn;
        }
        public List<Banks> BanksList()
        {
            List<Banks> banksList = new List<Banks>();
            SqlDataReader read = null;
            using (BanksDatabase bD = new BanksDatabase())
            {
                read = bD.BanksList();
                while (read.Read())
                {
                    Banks banks = new Banks()
                    {
                        BankaID = read.GetInt16(0),
                        BankaAdi = read.GetString(1),
                        Sube = read.GetString(2),
                        Iban = read.GetString(3),
                        HesapNo = read.GetString(4),
                        Yetkili = read.GetString(5),
                        Tarih = read.GetDateTime(6),
                        HesapTur = read.GetString(7),
                        FirmaId = read.GetString(8)
                    };
                    banksList.Add(banks);
                }
                read.Close();
            }
            return banksList;
        }
    }
}
