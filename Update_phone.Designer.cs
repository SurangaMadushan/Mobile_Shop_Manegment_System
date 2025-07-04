namespace Mobile_Shop_Manegment_System
{
    partial class Update_phone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_phone));
            button1 = new Button();
            label10 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(451, 489);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(270, 22);
            label10.Name = "label10";
            label10.Size = new Size(423, 32);
            label10.TabIndex = 23;
            label10.Text = "Update  Phone Stock Details";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(71, 283);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(330, 23);
            comboBox2.TabIndex = 31;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(71, 218);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(330, 23);
            comboBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(71, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 23);
            textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 23);
            textBox1.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(71, 259);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 24;
            label5.Text = "Internal Storage";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(71, 194);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 25;
            label4.Text = "Ram";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(71, 134);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 26;
            label3.Text = "Model Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(71, 70);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 27;
            label2.Text = "Company";
            // 
            // Update_phone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(888, 533);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(button1);
            Name = "Update_phone";
            Text = "Update_phone_Stock";
            Load += Update_phone_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label10;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}