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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Delete_phone delete_Phone = new Delete_phone();
            delete_Phone.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete_phone delete_Phone = new Delete_phone();
            delete_Phone.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Update_phone update_phone = new Update_phone();
            update_phone.Show();
            this.Hide();

        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }
    }
}
