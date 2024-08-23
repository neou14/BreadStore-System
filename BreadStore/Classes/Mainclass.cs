using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadStore.Classes
{
    public class Mainclass
    {
        private const string V = "Data Source=NOV;Initial Catalog=BreadstoreDB;Integrated Security=True";
        public static readonly string con_string = V;
        public static SqlConnection con = new SqlConnection(con_string);

        //Method to check user validation

        public static bool InvalidUser(string user, string pass)
        {
            bool isValid = false;
            string qry = @"select * from users where username = '" + user + "' and u_pass = '" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
