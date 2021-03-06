using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace DatabaseLogicLayer
{
    public class TaskDatabase : DatabaseConnection
    {
        public void TaskList(ComboBox cbx)
        {
            cmd = new SqlCommand("Select * from Gorevler", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbx.ValueMember = "GorevID";
            cbx.DisplayMember = "Gorev";
            cbx.DataSource = dt;
        }
    }
}
