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
    public partial class OUTPATIENT : Form
    {
        public OUTPATIENT()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

         
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string query = "SELECT * FROM dbo.EXAMINATION WHERE PID_Out='" + textBox1.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, cn);
                DataTable tblPatients = new DataTable();
                sda.Fill(tblPatients);
                dataGridView1.DataSource = tblPatients;

                string query1 = "SELECT * FROM dbo.Uses_Exam,dbo.MEDICATION WHERE MEDICATION.MID=Uses_Exam.MID AND PID_Out='"+textBox1.Text.Trim()+"'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, cn);
                DataTable tblPatients1 = new DataTable();
                sda1.Fill(tblPatients1);
                dataGridView2.DataSource = tblPatients1;
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
