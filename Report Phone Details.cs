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
    public partial class Report_Phone_Details : Form
    {
        public Report_Phone_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();

        }

        private void Report_Phone_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
