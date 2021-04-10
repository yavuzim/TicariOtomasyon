using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLogicLayer;
using Entities;
namespace BusinessLogicLayer
{
    public class TcKontrolBusiness
    {
        List<string> _Tclist = new List<string>();
        public TcKontrolBusiness()
        {
            SqlDataReader read = null;
            using (TcKontrolDatabase tcD = new TcKontrolDatabase())
            { 
                if (PersonnelBusiness.personnelTC == 1)
                    read = tcD.TcListPersonnel();
                while (read.Read())
                    _Tclist.Add(read.GetString(0));
            }
        }
        public bool TcListKontrol(string customer) // Ekleme işleminde T.C varsa false dönecek.
        {
            bool kontrol = true;
            for (int i = 0; i < _Tclist.Count; i++)
            {
                if (customer == _Tclist[i])
                {
                    kontrol = false;
                    break;
                }
            }
            return kontrol;
        }
        public void TcListKontrol2(string customer)
        {
            for (int i = 0; i < _Tclist.Count; i++)
            {
                if (customer == _Tclist[i])
                {
                    _Tclist.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
