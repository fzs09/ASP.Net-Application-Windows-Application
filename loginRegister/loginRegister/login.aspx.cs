using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace loginRegister
{
    public partial class login : System.Web.UI.Page
    {
        public static class Myconnection {

            public static SqlConnection getConnection() {

                string conn = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                SqlConnection myConn = new SqlConnection(conn);
                return myConn;
            
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnSignup_Click1(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var con = Myconnection.getConnection();
            if (con.State != ConnectionState.Open) {

                con.Open();
            }

            SqlCommand scmd = new SqlCommand("SPlogin",con);
            scmd.CommandType = CommandType.StoredProcedure;
            scmd.Parameters.AddWithValue("@uname",txtUserName.Text);
            scmd.Parameters.AddWithValue("@password", txtPassword.Text);

            SqlDataReader dr = scmd.ExecuteReader();
            if (dr.Read())
            {

                Response.Redirect("view.aspx");
            }
            else {

                Response.Write("invalid credentials");
            }

            con.Close();
        }

                
    }
}