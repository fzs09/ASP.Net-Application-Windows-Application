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
    public partial class register : System.Web.UI.Page
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

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.Length > 3)
            {

                args.IsValid = true;
            }
            else {

                args.IsValid = false;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var con = Myconnection.getConnection();
            if (con.State != ConnectionState.Open) {

                con.Open();
            }
            SqlCommand scmd = new SqlCommand("insertTotblRegistration",con);
            scmd.CommandType = CommandType.StoredProcedure;

            scmd.Parameters.AddWithValue("@uname",txtUserName.Text);
            scmd.Parameters["@uname"].Direction = ParameterDirection.Input;
            scmd.Parameters.AddWithValue("@pass", txtPassword.Text);
            scmd.Parameters["@pass"].Direction = ParameterDirection.Input;
            scmd.Parameters.AddWithValue("@gender", RadioButtonList1.Text);
            scmd.Parameters["@gender"].Direction = ParameterDirection.Input;
            scmd.Parameters.AddWithValue("@DOB", txtDOB.Text);
            scmd.Parameters["@DOB"].Direction = ParameterDirection.Input;
            scmd.Parameters.AddWithValue("@email", txtEmail.Text);
            scmd.Parameters["@email"].Direction = ParameterDirection.Input;
            scmd.Parameters.AddWithValue("@contact", txtContact.Text);
            scmd.Parameters["@contact"].Direction = ParameterDirection.Input;

            int result = scmd.ExecuteNonQuery();

            if (result == 1)
            {

                Response.Write("record inserted Successfully");
            }

            else {

                Response.Write("some problem happened");
            }
        }

        
    }
}