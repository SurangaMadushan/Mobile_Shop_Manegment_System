namespace Mobile_Shop_Manegment_System
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(12, 588);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(579, 27);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 2;
            label1.Text = "Phone Stock";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(142, 74);
            button2.Name = "button2";
            button2.Size = new Size(287, 41);
            button2.TabIndex = 3;
            button2.Text = "List Phone Stock";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(871, 74);
            button3.Name = "button3";
            button3.Size = new Size(261, 41);
            button3.TabIndex = 3;
            button3.Text = "Delete phone ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Menu;
            dataGridView1.Location = new Point(142, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(990, 439);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(520, 74);
            button4.Name = "button4";
            button4.Size = new Size(261, 41);
            button4.TabIndex = 5;
            button4.Text = "Update Phone Stock";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1246, 623);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
    }
}