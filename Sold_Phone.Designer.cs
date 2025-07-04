namespace Mobile_Shop_Manegment_System
{
    partial class Sold_Phone
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 29);
            label1.TabIndex = 2;
            label1.Text = "SOID PHONE RECORD";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 82);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 10;
            label2.Text = "Company";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(46, 125);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(315, 23);
            comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(537, 82);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 12;
            label3.Text = "Model";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(537, 125);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(315, 23);
            comboBox2.TabIndex = 13;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(806, 259);
            dataGridView1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(399, 162);
            label4.Name = "label4";
            label4.Size = new Size(85, 22);
            label4.TabIndex = 15;
            label4.Text = "details";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(421, 475);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Sold_Phone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 510);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sold_Phone";
            Text = "Sold_Phone";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private Label label4;
        private Button button1;
    }
}