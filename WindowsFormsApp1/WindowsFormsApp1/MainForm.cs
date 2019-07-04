using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PatientsForm objPatientsForm = new PatientsForm();
            objPatientsForm.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DoctorsForm objDoctorsForm = new DoctorsForm();
            objDoctorsForm.Show();
        }

        private void finance_Click(object sender, EventArgs e)
        {
            FinanceForm objFinanceForm = new FinanceForm();
            objFinanceForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            database obj = new database();
            obj.Show();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
              
        }
    }
}
