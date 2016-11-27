using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQconcept
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void GetData()
        {

            DataClasses1DataContext obj = new DataClasses1DataContext();
            GridView1.DataSource = obj.EmployeeInfos;
            GridView1.DataBind();
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            GetData();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext obj = new DataClasses1DataContext();
            EmployeeInfo emp = new EmployeeInfo
            {

                Eid = 156,
                Ename = "kamal",
                Esal = 6000
            };
            obj.EmployeeInfos.InsertOnSubmit(emp);
            obj.SubmitChanges();
            GetData();
        }
    }
}