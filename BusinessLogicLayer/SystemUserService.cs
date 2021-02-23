using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabaseLogicLayer;
using Entities;
namespace BusinessLogicLayer
{
    public class SystemUserService
    {
        public int SystemLogin(string KullaniciAd, string Sifre)
        {
            int returnResult = 0;
            if (string.IsNullOrEmpty(KullaniciAd) || string.IsNullOrEmpty(Sifre)) returnResult = 0;
            else
            {
                SystemUserDatabase userDatabase = new SystemUserDatabase();
                SystemUser systemUser = new SystemUser();
                systemUser.KullaniciAdi = KullaniciAd;
                systemUser.Sifre = Sifre;
                SqlDataReader read = userDatabase.SystemLogin(systemUser);
                bool oku = read.Read();
                if (oku)
                {
                    if (systemUser.KullaniciAdi == KullaniciAd && systemUser.Sifre == Sifre)
                        returnResult++;
                }
                else returnResult--;
                read.Close();
            }
            return returnResult;
        }
    }
}
