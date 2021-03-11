using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entities;

namespace DatabaseLogicLayer
{
    public class DebtDatabase : DatabaseConnection
    {
        public int DebdAdd(Debt debt)
        {
            int resultReturn;
            cmd = new SqlCommand("GiderEkle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            ConnectionWizard();
            cmd.Parameters.Add("@Ay", SqlDbType.NVarChar).Value = debt.Ay;
            cmd.Parameters.Add("@Yil", SqlDbType.NVarChar).Value = debt.Yil;
            cmd.Parameters.Add("@Elektrik", SqlDbType.Decimal).Value = debt.Elektrik;
            cmd.Parameters.Add("@Su", SqlDbType.Decimal).Value = debt.Su;
            cmd.Parameters.Add("@Dogalgaz", SqlDbType.Decimal).Value = debt.Dogalgaz;
            cmd.Parameters.Add("@Internet", SqlDbType.Decimal).Value = debt.Internet;
            cmd.Parameters.Add("@Maaslar", SqlDbType.Decimal).Value = debt.Maaslar;
            cmd.Parameters.Add("@Ekstra", SqlDbType.Decimal).Value = debt.Ekstra;
            cmd.Parameters.Add("@Notlar", SqlDbType.NVarChar).Value = debt.Notlar;
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public int DebdUpdate(Debt debt)
        {
            int resultReturn;
            cmd = new SqlCommand("GiderGuncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            ConnectionWizard();
            cmd.Parameters.Add("@GiderID", SqlDbType.Int).Value = debt.GiderID;
            cmd.Parameters.Add("@Ay", SqlDbType.NVarChar).Value = debt.Ay;
            cmd.Parameters.Add("@Yil", SqlDbType.NVarChar).Value = debt.Yil;
            cmd.Parameters.Add("@Elektrik", SqlDbType.Decimal).Value = debt.Elektrik;
            cmd.Parameters.Add("@Su", SqlDbType.Decimal).Value = debt.Su;
            cmd.Parameters.Add("@Dogalgaz", SqlDbType.Decimal).Value = debt.Dogalgaz;
            cmd.Parameters.Add("@Internet", SqlDbType.Decimal).Value = debt.Internet;
            cmd.Parameters.Add("@Maaslar", SqlDbType.Decimal).Value = debt.Maaslar;
            cmd.Parameters.Add("@Ekstra", SqlDbType.Decimal).Value = debt.Ekstra;
            cmd.Parameters.Add("@Notlar", SqlDbType.NVarChar).Value = debt.Notlar;
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public int DebdDelete(int GiderID)
        {
            int resultReturn;
            cmd = new SqlCommand("GiderSil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            ConnectionWizard();
            cmd.Parameters.Add("@GiderID", SqlDbType.Int).Value = GiderID;
            resultReturn = cmd.ExecuteNonQuery();
            ConnectionWizard();
            return resultReturn;
        }
        public SqlDataReader DebtList()
        {
            cmd = new SqlCommand("GiderListe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            ConnectionWizard();
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
