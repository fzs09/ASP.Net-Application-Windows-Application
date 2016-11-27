using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace RegisterDtls
{
    public partial class Form1 : Form
    {
        string Connection = ConfigurationManager.ConnectionStrings["DBconnection"].ToString();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connection);
            SqlDataAdapter da = new SqlDataAdapter("select* from EmployeeInfo", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource=ds.Tables[0];

        }
    }
}
