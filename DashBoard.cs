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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_New_Phone add_New_Phone = new Add_New_Phone();
            add_New_Phone.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sold_Phone sold_Phone = new Sold_Phone();
            sold_Phone.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer_details customer = new Customer_details();
            customer.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Repair_phone_Details repair_Phone_Details = new Repair_phone_Details();
            repair_Phone_Details.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Customer_purchase customer_Purchase = new Customer_purchase();
            customer_Purchase.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admin_logging admin_Logging = new Admin_logging();
            admin_Logging.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Report_Phone_Details report_Phone_Details= new Report_Phone_Details();
            report_Phone_Details.Show();
            this.Hide();

        }
    }
}
