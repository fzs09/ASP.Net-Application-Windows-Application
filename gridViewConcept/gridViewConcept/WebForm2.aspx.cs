using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace gridViewConcept
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=UB40203PC28\SQLEXPRESS;initial catalog=Araf;trusted_connection=true");
           // con.Open();
            //SqlCommand cmd = new SqlCommand("select* from EmployeeInfo",con);
            SqlDataAdapter da = new SqlDataAdapter("select* from EmployeeInfo",con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            //con.Close();
        }
    }
}