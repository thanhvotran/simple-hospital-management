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
    public partial class INPATIENT : Form
    {
        public INPATIENT()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cn.Open();
                string query = "SELECT* FROM dbo.INPATIENT WHERE PID_In='"+textBox1.Text.Trim()+"'";
                SqlCommand commandquery = new SqlCommand(query, cn);//perform query statement
                SqlDataAdapter deliver = new SqlDataAdapter(commandquery);
                DataTable tbl = new DataTable();//create virtual table
                deliver.Fill(tbl);// fulfil tbl table
                dataGridView1.DataSource = tbl;//virtual table to dataGrid

                string query1 = "SELECT* FROM dbo.Uses_Treat,dbo.MEDICATION WHERE MEDICATION.MID = Uses_Treat.MID AND PID_In='" + textBox1.Text.Trim() + "'";
                SqlCommand commandquery1 = new SqlCommand(query1, cn);//perform query statement
                SqlDataAdapter deliver1 = new SqlDataAdapter(commandquery1);
                DataTable tbl1 = new DataTable();//create virtual table
                deliver1.Fill(tbl1);// fulfil tbl table
                dataGridView2.DataSource = tbl1;//virtual table to dataGrid
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
