using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace loginRegister
{
    public partial class gridViewTask : System.Web.UI.Page
    {
        public static class Myconnection
        {

            public static SqlConnection getConnection()
            {

                string conn = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                SqlConnection myConn = new SqlConnection(conn);
                return myConn;

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var con = Myconnection.getConnection();
            if (con.State != ConnectionState.Open)
            {

                con.Open();
            }

            SqlCommand scmd = new SqlCommand("select* from tblRegistration", con);
            SqlDataReader dr = scmd.ExecuteReader();
            

            GridView1.DataSource = dr;
            GridView1.DataBind();
            
            dr.Close();
            con.Close();

        }
    }
}