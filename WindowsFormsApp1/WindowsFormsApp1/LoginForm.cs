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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HURT39H;Initial Catalog=ASSIGNMENT2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query="Select * from dbo.USERs where Accounts='"+textAccount.Text.Trim()+"' and Passwords='"+textPassword.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)//check database if user input a account data which means that it will be 1
            {
                MainForm objMainForm = new MainForm();
                this.Hide();
                objMainForm.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch (check)
            {
                case true:
                    textPassword.UseSystemPasswordChar = false;
                    break;
                default:
                    textPassword.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
