namespace Mobile_Shop_Manegment_System
{
    partial class Admin_logging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_logging));
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            Wrong_lable = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(513, 187);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(513, 294);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 0;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.InactiveCaption;
            txtUsername.Location = new Point(513, 237);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(235, 23);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveCaption;
            txtPassword.Location = new Point(513, 342);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(235, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(582, 451);
            button1.Name = "button1";
            button1.Size = new Size(92, 33);
            button1.TabIndex = 2;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Wrong_lable
            // 
            Wrong_lable.AutoSize = true;
            Wrong_lable.BackColor = Color.Transparent;
            Wrong_lable.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Wrong_lable.ForeColor = Color.Red;
            Wrong_lable.Location = new Point(499, 409);
            Wrong_lable.Name = "Wrong_lable";
            Wrong_lable.Size = new Size(267, 25);
            Wrong_lable.TabIndex = 3;
            Wrong_lable.Text = "Wrong Username or Password";
            Wrong_lable.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(1211, 2);
            button2.Name = "button2";
            button2.Size = new Size(43, 38);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Admin_logging
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1255, 596);
            Controls.Add(button2);
            Controls.Add(Wrong_lable);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin_logging";
            Text = "Admin_logging";
            Load += Admin_logging_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button button1;
        private Label Wrong_lable;
        private Button button2;
    }
}