namespace Mobile_Shop_Manegment_System
{
    public partial class Welcome_page : Form
    {
        public Welcome_page()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_logging admin_Logging = new Admin_logging();
            admin_Logging.Show();
            this.Hide();

        }
    }
}
