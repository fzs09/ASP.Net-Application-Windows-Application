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

namespace sampleWindowsForm
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtEid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

          

        }


        private void Display()
        {
            string connectionstr = null;
            connectionstr = "Data Source=UB40203PC28\\SQLEXPRESS;initial catalog=Araf;trusted_connection=true";
            SqlConnection connection = new SqlConnection(connectionstr);
            SqlCommand scmd = new SqlCommand("select* from EmployeeInfo", connection);
            SqlDataAdapter da = new SqlDataAdapter(scmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

           
            

        }
        private void Clear()
        {
            txtEid.Text = "";
            txtEname.Text = "";
            txtEsal.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionstr = null;
            connectionstr = "Data Source=UB40203PC28\\SQLEXPRESS;initial catalog=Araf;trusted_connection=true";
            SqlConnection connection = new SqlConnection(connectionstr);
            connection.Open();
            SqlCommand scmd = new SqlCommand("update EmployeeInfo set Ename ='" + txtEname.Text + "',Esal = " + txtEsal.Text + " where Eid = "+txtEid.Text+"", connection);
            int res = scmd.ExecuteNonQuery();

            if (res == 1)
            {

                MessageBox.Show("Record updated");
            }
            else
            {

                MessageBox.Show("record not updated");
            }

            connection.Close();
            Display();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionstr = null;
            connectionstr = "Data Source=UB40203PC28\\SQLEXPRESS;initial catalog=Araf;trusted_connection=true";
            SqlConnection connection = new SqlConnection(connectionstr);
            connection.Open();
            SqlCommand scmd = new SqlCommand("delete from EmployeeInfo where Eid = "+txtEid.Text+"", connection);
            int res = scmd.ExecuteNonQuery();

            if (res == 1)
            {

                MessageBox.Show("Record deleted");
            }
            else
            {

                MessageBox.Show("record not deleted");
            }

            connection.Close();
            Display();
            Clear();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionstr = null;
            connectionstr = "Data Source=UB40203PC28\\SQLEXPRESS;initial catalog=Araf;trusted_connection=true";
            SqlConnection connection = new SqlConnection(connectionstr);
            connection.Open();
            SqlCommand scmd = new SqlCommand("insert into EmployeeInfo(Eid,Ename,Esal)values(" + txtEid.Text + ",'" + txtEname.Text + "'," + txtEsal.Text + ")", connection);
            int res = scmd.ExecuteNonQuery();

            if (res == 1)
            {

                MessageBox.Show("Record inserted");
            }
            else
            {

                MessageBox.Show("record not inserted");
            }

            connection.Close();
            Display();
            Clear();

        }
    }
}
