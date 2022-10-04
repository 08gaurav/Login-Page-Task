using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task1_3_Tier_App
{
    public partial class Login : System.Web.UI.Page
    {
        dal da = new dal();
        bal ba = new bal();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
        }
         
            protected void Button1_Click(object sender, EventArgs e)
            {
                da.U_name = TextBox1.Text;
                da.U_password = TextBox2.Text;
                dt = ba.ulogin(da);
                if (dt.Rows.Count > 0)
                {
                    Session["UserName"] = TextBox1.Text.ToString();
                    Response.Redirect("home.aspx");

                }
                else
                {
                    Response.Write("< script > alert('Not a valid user!.') </ script >");
                }
            }
    }
    
}