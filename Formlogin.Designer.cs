namespace DesktopApp
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            label4 = new Label();
            button1 = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(164, 165, 169);
            label4.Location = new Point(430, 471);
            label4.Name = "label4";
            label4.Size = new Size(137, 22);
            label4.TabIndex = 22;
            label4.Text = "Tidak Memiliki Akun?";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(55, 163, 165);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(390, 381);
            button1.Name = "button1";
            button1.Size = new Size(300, 38);
            button1.TabIndex = 20;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Poppins SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(390, 312);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 35);
            txtPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(164, 165, 169);
            label3.Location = new Point(393, 292);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(230, 231, 233);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Poppins SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(390, 247);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 35);
            txtEmail.TabIndex = 14;
            txtEmail.TextChanged += textusername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(164, 165, 169);
            label2.Location = new Point(393, 227);
            label2.Name = "label2";
            label2.Size = new Size(43, 22);
            label2.TabIndex = 13;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(55, 163, 165);
            label1.Location = new Point(449, 159);
            label1.Name = "label1";
            label1.Size = new Size(184, 36);
            label1.TabIndex = 12;
            label1.Text = "Selamat Datang";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(490, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(164, 165, 169);
            label6.Location = new Point(485, 186);
            label6.Name = "label6";
            label6.Size = new Size(109, 23);
            label6.TabIndex = 26;
            label6.Text = "Silahkan Login";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(55, 163, 165);
            label5.Location = new Point(570, 471);
            label5.Name = "label5";
            label5.Size = new Size(86, 22);
            label5.TabIndex = 23;
            label5.Text = "Daftar AKUN";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(164, 165, 169);
            label7.Location = new Point(581, 422);
            label7.Name = "label7";
            label7.Size = new Size(109, 22);
            label7.TabIndex = 27;
            label7.Text = "Lupa Password?";
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(230, 231, 233);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(655, 312);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 28;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(230, 231, 233);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(655, 312);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 29;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Formlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 600);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Formlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formlogin";
            WindowState = FormWindowState.Maximized;
            Load += Formlogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Button button1;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label7;
        private Button button2;
        private Button button3;
    }
}