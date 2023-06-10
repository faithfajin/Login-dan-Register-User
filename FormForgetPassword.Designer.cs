namespace Login_dan_Register_Project_PBO_A
{
    partial class FormForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgetPassword));
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(164, 165, 169);
            label6.Location = new Point(348, 211);
            label6.Name = "label6";
            label6.Size = new Size(390, 20);
            label6.TabIndex = 38;
            label6.Text = "Please, enter your email address, You will receive a link";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(490, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(55, 163, 165);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(390, 354);
            button1.Name = "button1";
            button1.Size = new Size(300, 38);
            button1.TabIndex = 34;
            button1.Text = "Send reset password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(230, 231, 233);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(390, 310);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 35);
            txtEmail.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(164, 165, 169);
            label2.Location = new Point(387, 290);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 29;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(55, 163, 165);
            label1.Location = new Point(454, 181);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 28;
            label1.Text = "Forgot Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(164, 165, 169);
            label8.Location = new Point(419, 229);
            label8.Name = "label8";
            label8.Size = new Size(253, 20);
            label8.TabIndex = 40;
            label8.Text = "to create a new password via email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(55, 163, 165);
            label5.Location = new Point(496, 397);
            label5.Name = "label5";
            label5.Size = new Size(89, 17);
            label5.TabIndex = 41;
            label5.Text = "Back to login";
            label5.Click += label5_Click;
            // 
            // FormForgetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 600);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormForgetPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label5;
        private TextBox txtEmail;
    }
}