namespace Mobile_Shop_Manegment_System
{
    partial class Customer_details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_details));
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(405, 406);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(291, 29);
            label2.Name = "label2";
            label2.Size = new Size(279, 32);
            label2.TabIndex = 3;
            label2.Text = "customer records";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(59, 111);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 4;
            label1.Text = "Customer Name :";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientActiveCaption;
            textBox1.Location = new Point(226, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(709, 243);
            dataGridView1.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Location = new Point(669, 110);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Customer_details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Customer_details";
            Text = "Customer_details";
            Load += Customer_details_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button2;
    }
}