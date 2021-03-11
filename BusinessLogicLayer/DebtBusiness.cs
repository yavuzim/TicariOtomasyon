using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLogicLayer;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class DebtBusiness
    {
        public int DebdAdd(string Ay, string Yil, decimal Elektrik, decimal Su, decimal Dogalgaz, decimal Internet, decimal Maaslar, decimal Ekstra, string Notlar)
        {
            int resultReturn = 0;
            using (DebtDatabase dD = new DebtDatabase())
            {
                Debt debt = new Debt()
                {
                    Ay = Ay,
                    Yil = Yil,
                    Elektrik = Elektrik,
                    Su = Su,
                    Dogalgaz = Dogalgaz,
                    Internet = Internet,
                    Maaslar = Maaslar,
                    Ekstra = Ekstra,
                    Notlar = Notlar
                };
                if (string.IsNullOrEmpty(debt.Yil) || debt.Elektrik == 0 || debt.Su == 0 || debt.Dogalgaz == 0 || debt.Maaslar == 0 || debt.Ekstra == 0) resultReturn = 0;
                else
                {
                    if (!debt._yilLength) resultReturn = 1;
                    else
                    {
                        if (debt.Elektrik < 0 || debt.Su < 0 || debt.Dogalgaz < 0 || debt.Internet < 0 || debt.Maaslar < 0 || debt.Ekstra < 0) resultReturn = 2;
                        else
                        {
                            resultReturn = dD.DebdAdd(debt);
                            resultReturn = 3;
                        }
                    }
                }
            }
            return resultReturn;
        }
        public int DebdUpdate(int GiderID, string Ay, string Yil, decimal Elektrik, decimal Su, decimal Dogalgaz, decimal Internet, decimal Maaslar, decimal Ekstra, string Notlar)
        {
            int resultReturn = 0;
            using (DebtDatabase dD = new DebtDatabase())
            {
                Debt debt = new Debt()
                {
                    GiderID = GiderID,
                    Ay = Ay,
                    Yil = Yil,
                    Elektrik = Elektrik,
                    Su = Su,
                    Dogalgaz = Dogalgaz,
                    Internet = Internet,
                    Maaslar = Maaslar,
                    Ekstra = Ekstra,
                    Notlar = Notlar
                };
                if (string.IsNullOrEmpty(debt.Yil) || debt.Elektrik == 0 || debt.Su == 0 || debt.Dogalgaz == 0 || debt.Maaslar == 0 || debt.Ekstra == 0) resultReturn = 0;
                else
                {
                    if (!debt._yilLength) resultReturn = 1;
                    else
                    {
                        if (debt.Elektrik < 0 || debt.Su < 0 || debt.Dogalgaz < 0 || debt.Internet < 0 || debt.Maaslar < 0 || debt.Ekstra < 0) resultReturn = 2;
                        else
                        {
                            resultReturn = dD.DebdUpdate(debt);
                            resultReturn = 3;
                        }
                    }
                }
            }
            return resultReturn;
        }
        public int DebdDelete(int GiderID)
        {
            int resultReturn = 0;
            using (DebtDatabase dD = new DebtDatabase())
            {
                resultReturn = dD.DebdDelete(GiderID);
            }
            return resultReturn;
        }
        public List<Debt> DebtList()
        {
            List<Debt> debtList = new List<Debt>();
            SqlDataReader read = null;
            using (DebtDatabase dD = new DebtDatabase())
            {
                read = dD.DebtList();
                while (read.Read())
                {
                    Debt debt = new Debt()
                    {
                        GiderID = read.GetInt32(0),
                        Ay = read.GetString(1),
                        Yil = read.GetString(2),
                        Elektrik = read.GetDecimal(3),
                        Su = read.GetDecimal(4),
                        Dogalgaz = read.GetDecimal(5),
                        Internet = read.GetDecimal(6),
                        Maaslar = read.GetDecimal(7),
                        Ekstra = read.GetDecimal(8),
                        Notlar = read.GetString(9)
                    };
                    debtList.Add(debt);
                }
                read.Close();
            }
            return debtList;
        }
    }
}
