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
    public partial class PatientsForm : Form
    {
        public PatientsForm()
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
                dataPatient.DataSource = tbl;//virtual table to dataGrid
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "SELECT * FROM dbo.PATIENT where PFname='"+textF.Text.Trim()+"'or PLname='"+textL.Text.Trim()+"'or PID='"+textPID.Text.Trim()+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, cn);
            DataTable tblPatients = new DataTable();
            sda.Fill(tblPatients);
            dataPatient.DataSource = tblPatients;
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }
    }   
}
