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
    public partial class Delete_phone : Form
    {
        public Delete_phone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }

        private void Delete_phone_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();  
            stock.Show();
            this.Hide();

        }
    }
}
