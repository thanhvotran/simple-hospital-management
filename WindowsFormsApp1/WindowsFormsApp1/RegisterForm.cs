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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PGenre_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            connection();
        }

        int index;
        //show information in text boxes evertime we click any cells
        private void dataGridViewGrid1_click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            textPID.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textPFname.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textPLname.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textPDoB.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            textPGender.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            textPPhone.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            textPAddress.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            textPGenre.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();

        }

        string add_query;
        private void PAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cn.Open();
                add_query = "INSERT INTO dbo.PATIENT VALUES('" + textPID.Text.Trim() + "','" + textPFname.Text.Trim() + "','" + textPLname.Text.Trim() + "','" + textPDoB.Text.Trim() + "','" + textPGender.Text.Trim() + "','" + textPPhone.Text.Trim() + "','" + textPAddress.Text.Trim() + "','" + textPGenre.Text.Trim() + "')";
               // string add = "INSERT INTO dbo.PATIENT VALUES("''",'Kii','kee','19960202','M',0123456789,'44 UUUU Streest, Mland','in')";

                SqlCommand commandAdd = new SqlCommand(add_query, cn);
                commandAdd.ExecuteNonQuery();
                connection();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPID_TextChanged(object sender, EventArgs e)
        {

        }


        string removeP;
       // string removein;
       // string removeout;
        //string removeRegis_Form;
        private void PRemove_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cn.Open();
                removeP = "delete dbo.PATIENT WHERE PID ='" + textPID.Text.Trim() + "'";
               // removein = "delete dbo.OUTPATIENT WHERE PID_Out='" + textPID + "'";
               // removeout = "delete dbo.INPATIENT WHERE PID_In='" + textPID + "'";
                SqlCommand comm = new SqlCommand(removeP, cn);
               // SqlCommand comm1 = new SqlCommand(removein, cn);
               // SqlCommand comm2 = new SqlCommand(removeout, cn);
                comm.ExecuteNonQuery();
              //  comm1.ExecuteNonQuery();
              //  comm2.ExecuteNonQuery();
                connection();
                
            }
            catch
            {
                MessageBox.Show("error, can not remove");
            }
            finally
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cn.Close();
            }
        }
        string edit;
        private void PEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cn.Open();
                edit = "update dbo.PATIENT set PFname='" + textPFname.Text.Trim() + "',PLname='" + textPLname.Text.Trim() + "',PDoB='" + textPDoB.Text.Trim() + "',PGender='" + textPGender.Text.Trim() + "',PPhone='" + textPPhone.Text.Trim() + "',PAddress='" + textPAddress.Text.Trim() + "',PGenre='" + textPGenre.Text.Trim() + "' where PID='" + textPID.Text.Trim() + "'";
                SqlCommand comm = new SqlCommand(edit, cn);
                comm.ExecuteNonQuery();
                connection();

            }
            catch
            {
                MessageBox.Show("Error, cannot edit");
            }
            finally
            {

                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cn.Close();
            }
        }
    }
}
