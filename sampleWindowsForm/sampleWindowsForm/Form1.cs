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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = null;
            connectionString = "Data Source =UB40203PC28\\SQLEXPRESS;Initial Catalog=Araf;trusted_connection=true";
            SqlConnection cnn = new SqlConnection(connectionString);

            try
            {

                cnn.Open();
                MessageBox.Show("connection open");
                cnn.Close();
            }

            catch (Exception ex) {

                MessageBox.Show("cannot open connection");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSelect_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void lblInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
