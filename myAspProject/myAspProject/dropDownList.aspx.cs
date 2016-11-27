using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myAspProject
{
    public partial class dropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {

                ddlDay.Items.Add(i.ToString());
            }
            ddlDay.Items.Insert(0, "--select th day");

            for (int i = 1; i <= 12; i++) {

                ddlMonth.Items.Add(i.ToString());
            }
            ddlMonth.Items.Insert(0,"select the month");

            for (int i = 1947; i <= 2016; i++) {

                ddlYear.Items.Add(i.ToString());
            }
            ddlYear.Items.Insert(0,"select the year");

            int y = Convert.ToInt32(ddlYear.Text);
            int m = Convert.ToInt32(ddlMonth.Text);
            if (y % 4 == 0 && m==2) {

                for (int i = 1; i <= 29; i++)
                {

                    ddlDay.Items.Add(i.ToString());
                }
                ddlDay.Items.Insert(0, "--select th day");
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rdbMale.Checked == true)
            {

                Response.Write("you selected : <br>" + rdbMale.Text);
            }
            else {

                Response.Write("you selected : <br>" + rdbFemale.Text);
            }
        }

        protected void rdbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}