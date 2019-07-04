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
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();
        }

        private void connection()
        {
            try
            {

                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cn.Open();
                string query = "select * from dbo.PATIENT";
                SqlCommand commandquery = new SqlCommand(query, cn);//perform query statement
                SqlDataAdapter deliver = new SqlDataAdapter(commandquery);
                DataTable tbl = new DataTable();//create virtual table
                deliver.Fill(tbl);// fulfil tbl table
                table.DataSource = tbl;//virtual table to dataGrid
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string doctor;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cn.Open();
                doctor = "EXEC dbo.Patient_Doctor_Func @EID_Doc = '" + textDoc_ID.Text.Trim() + "' ";
                SqlCommand commandAdd = new SqlCommand(doctor, cn);
               // commandAdd.ExecuteNonQuery();
                SqlDataAdapter deliver = new SqlDataAdapter(commandAdd);
                DataTable tbl = new DataTable();//create virtual table
                deliver.Fill(tbl);// fulfil tbl table
                table.DataSource = tbl;//virtual table to dataGrid
                //  commandAdd.ExecuteNonQuery();
                //connection();
            }
            catch
            {
                MessageBox.Show("ERROR, CAN NOT ADD ");
            }   
            finally
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cn.Close();
            }
        }
    }
}
