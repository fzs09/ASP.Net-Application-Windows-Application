using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQconcept
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            DataClasses1DataContext obj = new DataClasses1DataContext();
            GridView1.DataSource = from employee in obj.EmployeeInfos
                                   where employee.Esal > 3000
                                   orderby employee.Ename descending
                                   select employee;
            GridView1.DataBind();
 
        }
    }
}