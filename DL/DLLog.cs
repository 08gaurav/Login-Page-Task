using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DLLog
    {
        SqlDBHelper sql = new SqlDBHelper();
        public DataTable LoginCredential(BE.BELog belogin)
        {
            string connectionString = sql.ConnectionString();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from UserProfile where UserName = '" + belogin.Name + "' and Password='" + belogin.Password + "'", con);
            da.Fill(dt);
            con.Close();
            return dt;

        }
    }
}
