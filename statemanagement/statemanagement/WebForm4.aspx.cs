using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace statemanagement
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text=Request.QueryString[0];
            //Label2.Text=Request.QueryString[1];

            int newVal = Convert.ToInt32(HiddenField1.Value) + 1;
            HiddenField1.Value = newVal.ToString();
            Label1.Text = HiddenField1.Value;

        }
    }
}