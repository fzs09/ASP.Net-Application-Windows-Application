using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace homeWork_1
{
    public partial class session1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Session["UserName"] = txtUserName.Text;
            Session["Password"] = txtPassword.Text;

            Response.Redirect("session2.aspx");
        }
    }
}