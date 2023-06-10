namespace Login_dan_Register_Project_PBO_A
{
    partial class FormNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewPassword));
            checkBoxTampilkanPassword = new CheckBox();
            txtpassword2 = new TextBox();
            textKonfirmasiPassowrd = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBoxTampilkanPassword
            // 
            checkBoxTampilkanPassword.Anchor = AnchorStyles.None;
            checkBoxTampilkanPassword.AutoSize = true;
            checkBoxTampilkanPassword.Cursor = Cursors.Hand;
            checkBoxTampilkanPassword.FlatStyle = FlatStyle.Flat;
            checkBoxTampilkanPassword.Location = new Point(537, 346);
            checkBoxTampilkanPassword.Name = "checkBoxTampilkanPassword";
            checkBoxTampilkanPassword.Size = new Size(150, 21);
            checkBoxTampilkanPassword.TabIndex = 12;
            checkBoxTampilkanPassword.Text = "Tampilkan Password";
            checkBoxTampilkanPassword.UseVisualStyleBackColor = true;
            checkBoxTampilkanPassword.CheckedChanged += checkBoxTampilkanPassword_CheckedChanged;
            // 
            // txtpassword2
            // 
            txtpassword2.Anchor = AnchorStyles.None;
            txtpassword2.BackColor = Color.FromArgb(230, 231, 233);
            txtpassword2.BorderStyle = BorderStyle.None;
            txtpassword2.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword2.Location = new Point(390, 308);
            txtpassword2.Multiline = true;
            txtpassword2.Name = "txtpassword2";
            txtpassword2.PasswordChar = '*';
            txtpassword2.Size = new Size(300, 35);
            txtpassword2.TabIndex = 11;
            // 
            // textKonfirmasiPassowrd
            // 
            textKonfirmasiPassowrd.Anchor = AnchorStyles.None;
            textKonfirmasiPassowrd.AutoSize = true;
            textKonfirmasiPassowrd.Location = new Point(386, 288);
            textKonfirmasiPassowrd.Name = "textKonfirmasiPassowrd";
            textKonfirmasiPassowrd.Size = new Size(137, 17);
            textKonfirmasiPassowrd.TabIndex = 10;
            textKonfirmasiPassowrd.Text = "Konfirmasi Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(390, 251);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 35);
            txtPassword.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(387, 233);
            label3.Name = "label3";
            label3.Size = new Size(97, 17);
            label3.TabIndex = 8;
            label3.Text = "New Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(485, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(55, 163, 165);
            label1.Location = new Point(457, 197);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 47;
            label1.Text = "New Password";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(55, 163, 165);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(390, 369);
            button1.Name = "button1";
            button1.Size = new Size(300, 38);
            button1.TabIndex = 49;
            button1.Text = "Reset Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormNewPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 600);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(checkBoxTampilkanPassword);
            Controls.Add(txtpassword2);
            Controls.Add(textKonfirmasiPassowrd);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            Name = "FormNewPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNewPassword";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxTampilkanPassword;
        private TextBox txtpassword2;
        private Label textKonfirmasiPassowrd;
        private TextBox txtPassword;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
    }
}