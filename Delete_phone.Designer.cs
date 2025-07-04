namespace Mobile_Shop_Manegment_System
{
    partial class Delete_phone
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
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 530);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 0;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(320, 28);
            label2.Name = "label2";
            label2.Size = new Size(281, 29);
            label2.TabIndex = 2;
            label2.Text = "DELETE PHONE RECORD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(123, 119);
            label1.Name = "label1";
            label1.Size = new Size(151, 23);
            label1.TabIndex = 21;
            label1.Text = "COMPANY OR MODEL";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(132, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(436, 470);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 29;
            button2.Text = "Go Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(414, 157);
            label4.Name = "label4";
            label4.Size = new Size(85, 22);
            label4.TabIndex = 28;
            label4.Text = "details";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(806, 259);
            dataGridView1.TabIndex = 27;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(552, 120);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(315, 25);
            comboBox2.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(552, 77);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 25;
            label3.Text = "Model";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(61, 120);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(315, 25);
            comboBox3.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 77);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 23;
            label5.Text = "Company";
            // 
            // Delete_phone
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(928, 570);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Delete_phone";
            Text = "Delete_phone";
            Load += Delete_phone_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Button button2;
        private Label label4;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox3;
        private Label label5;
    }
}