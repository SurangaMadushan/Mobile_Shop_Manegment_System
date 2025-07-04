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
using System.Data;


namespace Mobile_Shop_Manegment_System
{
    public partial class Admin_logging : Form
    {
        public Admin_logging()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "suranga" && txtPassword.Text == "1234")
            {

                DashBoard dashBoard = new DashBoard();
                dashBoard.Show();
                this.Hide();



            }
            else
            {
                this.Show();
                Wrong_lable.Visible = true;

            }



        }



        private void Admin_logging_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
