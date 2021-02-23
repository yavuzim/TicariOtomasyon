using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DatabaseLogicLayer
{
    public class City : DatabaseConnection
    {
        public void GetCity(ComboBox city)
        {
            ConnectionWizard();
            cmd = new SqlCommand("select * from Sehirler", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            city.ValueMember = "SehirId";
            city.DisplayMember = "Sehir";
            city.DataSource = dt;
            ConnectionWizard();
        }
        public void GetCounty(ComboBox city, ComboBox county)
        {
            ConnectionWizard();
            cmd = new SqlCommand("select * from Ilceler where SehirId=@sehirid", con);
            cmd.Parameters.AddWithValue("@sehirid", city.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            county.ValueMember = "IldeId";
            county.DisplayMember = "Ilce";
            county.DataSource = dt;
            ConnectionWizard();
        }
    }
}
