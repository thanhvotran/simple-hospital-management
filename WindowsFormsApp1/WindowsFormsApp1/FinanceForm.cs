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
    public partial class FinanceForm : Form
    {
        public FinanceForm()
        {
            InitializeComponent();
        }

        private void FinanceForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonPID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OUTPATIENT obj = new OUTPATIENT();
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            INPATIENT obj = new INPATIENT();
            obj.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            QUICKMEDICALPRICE obj = new QUICKMEDICALPRICE();
            obj.Show();
        }
    }
}
