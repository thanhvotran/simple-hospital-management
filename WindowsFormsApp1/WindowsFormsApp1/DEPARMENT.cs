using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class DEPARMENT : Form
    {
        public DEPARMENT()
        {
            InitializeComponent();
        }

        private void DEPARMENT_Load(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cn.Open();
                string query = "select * from dbo.DEPARTMENT";
                SqlCommand commandquery = new SqlCommand(query, cn);//perform query statement
                SqlDataAdapter deliver = new SqlDataAdapter(commandquery);
                DataTable tbl = new DataTable();//create virtual table
                deliver.Fill(tbl);// fulfil tbl table
                dataGridView1.DataSource = tbl;//virtual table to dataGrid
            }
            catch
            {
                MessageBox.Show("Fail connection, check again !");
            }
            finally
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cn.Close();
            }

        }
    }
}
