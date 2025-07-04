namespace Mobile_Shop_Manegment_System
{
    partial class Repair_phone_Details
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(370, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(52, 53);
            button2.Name = "button2";
            button2.Size = new Size(262, 23);
            button2.TabIndex = 1;
            button2.Text = "Add New Repair Phone";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(474, 53);
            button3.Name = "button3";
            button3.Size = new Size(222, 23);
            button3.TabIndex = 2;
            button3.Text = "List Repair Phone";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(677, 257);
            dataGridView1.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(232, 9);
            label10.Name = "label10";
            label10.Size = new Size(329, 32);
            label10.TabIndex = 19;
            label10.Text = "Repair  Phone Details";
            // 
            // Repair_phone_Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Repair_phone_Details";
            Text = "Repair_phone_Details";
            Load += Repair_phone_Details_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label10;
    }
}