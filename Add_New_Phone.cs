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
    public partial class Add_New_Phone : Form
    {
        public Add_New_Phone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }

        private void Add_New_Phone_Load(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
