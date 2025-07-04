namespace Mobile_Shop_Manegment_System
{
    partial class Welcome_page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>ghjkjhgfdfghjkl
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_page));
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.Cyan;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(498, 568);
            button1.Name = "button1";
            button1.Size = new Size(336, 31);
            button1.TabIndex = 0;
            button1.Text = "Click Here\r\n";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Welcome_page
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1284, 621);
            Controls.Add(button1);
            Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Welcome_page";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Welcome_Page";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
    }
}
