using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace homeWork_1
{
    public partial class session2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string address = txtAddress.Text;
            string contact = txtContact.Text;
            String name = Session["UserName"].ToString();
            String pass = Session["Password"].ToString();

            string conn = @"Data Source=UB40203PC28\SQLEXPRESS;Initial Catalog=Araf;Trusted_Connection=true";
            SqlConnection myConn = new SqlConnection(conn);
            myConn.Open();
            SqlCommand cmd = new SqlCommand("spinsert",myConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uname",name);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@contact", contact);

            cmd.ExecuteNonQuery();
            myConn.Close();




        }
    }
}