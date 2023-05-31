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
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            checkBoxTampilkanPassword = new CheckBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.FlatStyle = FlatStyle.Flat;
            label5.ForeColor = Color.FromArgb(8, 212, 116);
            label5.Location = new Point(496, 454);
            label5.Name = "label5";
            label5.Size = new Size(87, 17);
            label5.TabIndex = 23;
            label5.Text = "Daftar AKUN";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(164, 165, 169);
            label4.Location = new Point(476, 437);
            label4.Name = "label4";
            label4.Size = new Size(136, 17);
            label4.TabIndex = 22;
            label4.Text = "Tidak Memiliki Akun";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(8, 212, 116);
            button2.Location = new Point(430, 383);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 21;
            button2.Text = "Hapus";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 212, 116);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(430, 333);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 20;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBoxTampilkanPassword
            // 
            checkBoxTampilkanPassword.AutoSize = true;
            checkBoxTampilkanPassword.Cursor = Cursors.Hand;
            checkBoxTampilkanPassword.FlatStyle = FlatStyle.Flat;
            checkBoxTampilkanPassword.ForeColor = Color.FromArgb(164, 165, 169);
            checkBoxTampilkanPassword.Location = new Point(502, 296);
            checkBoxTampilkanPassword.Name = "checkBoxTampilkanPassword";
            checkBoxTampilkanPassword.Size = new Size(150, 21);
            checkBoxTampilkanPassword.TabIndex = 19;
            checkBoxTampilkanPassword.Text = "Tampilkan Password";
            checkBoxTampilkanPassword.UseVisualStyleBackColor = true;
            checkBoxTampilkanPassword.CheckedChanged += checkBoxTampilkanPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(430, 261);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(164, 165, 169);
            label3.Location = new Point(430, 241);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(430, 196);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 14;
            txtUsername.TextChanged += textusername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(164, 165, 169);
            label2.Location = new Point(436, 176);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 212, 116);
            label1.Location = new Point(430, 122);
            label1.Name = "label1";
            label1.Size = new Size(78, 27);
            label1.TabIndex = 12;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(-11, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // Formlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 600);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBoxTampilkanPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formlogin";
            Load += Formlogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Button button2;
        private Button button1;
        private CheckBox checkBoxTampilkanPassword;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}