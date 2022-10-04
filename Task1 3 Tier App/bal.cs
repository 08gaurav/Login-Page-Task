using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Task1_3_Tier_App
{
    public class bal
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-K8HV19R; Integrated Security = true; Initial Catalog = Test");

        public DataTable ulogin(dal da)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter("select * from UserProfile where UserName = '" + da.U_name + "' and Password='" + da.U_password + "'", con);

            sda.Fill(dt);

            return dt;
        }
    }
}