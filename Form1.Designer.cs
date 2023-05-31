namespace DesktopApp
{
    partial class FormRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            txtPassword = new TextBox();
            label3 = new Label();
            txtpassword2 = new TextBox();
            textKonfirmasiPassowrd = new Label();
            checkBoxTampilkanPassword = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            txtNama = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtNo = new TextBox();
            label9 = new Label();
            label2 = new Label();
            label10 = new Label();
            txtProvinsi = new TextBox();
            txtKota = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(430, 265);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 247);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txtpassword2
            // 
            txtpassword2.BackColor = Color.FromArgb(230, 231, 233);
            txtpassword2.BorderStyle = BorderStyle.None;
            txtpassword2.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword2.Location = new Point(430, 315);
            txtpassword2.Multiline = true;
            txtpassword2.Name = "txtpassword2";
            txtpassword2.PasswordChar = '*';
            txtpassword2.Size = new Size(216, 28);
            txtpassword2.TabIndex = 6;
            // 
            // textKonfirmasiPassowrd
            // 
            textKonfirmasiPassowrd.AutoSize = true;
            textKonfirmasiPassowrd.Location = new Point(430, 295);
            textKonfirmasiPassowrd.Name = "textKonfirmasiPassowrd";
            textKonfirmasiPassowrd.Size = new Size(137, 17);
            textKonfirmasiPassowrd.TabIndex = 5;
            textKonfirmasiPassowrd.Text = "Konfirmasi Password";
            // 
            // checkBoxTampilkanPassword
            // 
            checkBoxTampilkanPassword.AutoSize = true;
            checkBoxTampilkanPassword.Cursor = Cursors.Hand;
            checkBoxTampilkanPassword.FlatStyle = FlatStyle.Flat;
            checkBoxTampilkanPassword.Location = new Point(496, 346);
            checkBoxTampilkanPassword.Name = "checkBoxTampilkanPassword";
            checkBoxTampilkanPassword.Size = new Size(150, 21);
            checkBoxTampilkanPassword.TabIndex = 7;
            checkBoxTampilkanPassword.Text = "Tampilkan Password";
            checkBoxTampilkanPassword.UseVisualStyleBackColor = true;
            checkBoxTampilkanPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 212, 116);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(431, 475);
            button1.Name = "button1";
            button1.Size = new Size(216, 30);
            button1.TabIndex = 8;
            button1.Text = "Daftar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(8, 212, 116);
            button2.Location = new Point(431, 511);
            button2.Name = "button2";
            button2.Size = new Size(216, 30);
            button2.TabIndex = 9;
            button2.Text = "Hapus";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(467, 547);
            label4.Name = "label4";
            label4.Size = new Size(140, 17);
            label4.TabIndex = 10;
            label4.Text = "Sudah Memiliki Akun";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.FlatStyle = FlatStyle.Flat;
            label5.ForeColor = Color.FromArgb(8, 212, 116);
            label5.Location = new Point(477, 564);
            label5.Name = "label5";
            label5.Size = new Size(120, 17);
            label5.TabIndex = 11;
            label5.Text = "Kembali ke LOGIN";
            label5.Click += label5_Click;
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.FromArgb(230, 231, 233);
            txtNama.BorderStyle = BorderStyle.None;
            txtNama.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(430, 119);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(216, 28);
            txtNama.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(430, 99);
            label7.Name = "label7";
            label7.Size = new Size(100, 17);
            label7.TabIndex = 13;
            label7.Text = "Nama Lengkap";
            label7.Click += label7_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(230, 231, 233);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(430, 168);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 28);
            txtEmail.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(430, 150);
            label8.Name = "label8";
            label8.Size = new Size(42, 17);
            label8.TabIndex = 15;
            label8.Text = "Email";
            label8.Click += label8_Click;
            // 
            // txtNo
            // 
            txtNo.BackColor = Color.FromArgb(230, 231, 233);
            txtNo.BorderStyle = BorderStyle.None;
            txtNo.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNo.Location = new Point(430, 217);
            txtNo.Multiline = true;
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(216, 28);
            txtNo.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(430, 199);
            label9.Name = "label9";
            label9.Size = new Size(48, 17);
            label9.TabIndex = 17;
            label9.Text = "No Hp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(431, 365);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 19;
            label2.Text = "Provinsi";
            label2.Click += label2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(431, 416);
            label10.Name = "label10";
            label10.Size = new Size(36, 17);
            label10.TabIndex = 21;
            label10.Text = "Kota";
            // 
            // txtProvinsi
            // 
            txtProvinsi.BackColor = Color.FromArgb(230, 231, 233);
            txtProvinsi.BorderStyle = BorderStyle.None;
            txtProvinsi.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProvinsi.Location = new Point(431, 385);
            txtProvinsi.Multiline = true;
            txtProvinsi.Name = "txtProvinsi";
            txtProvinsi.Size = new Size(216, 28);
            txtProvinsi.TabIndex = 22;
            // 
            // txtKota
            // 
            txtKota.BackColor = Color.FromArgb(230, 231, 233);
            txtKota.BorderStyle = BorderStyle.None;
            txtKota.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtKota.Location = new Point(431, 436);
            txtKota.Multiline = true;
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(216, 28);
            txtKota.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(-11, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 212, 116);
            label1.Location = new Point(430, 57);
            label1.Name = "label1";
            label1.Size = new Size(88, 27);
            label1.TabIndex = 27;
            label1.Text = "Daftar";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 600);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtKota);
            Controls.Add(txtProvinsi);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(txtNo);
            Controls.Add(label9);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(txtNama);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBoxTampilkanPassword);
            Controls.Add(txtpassword2);
            Controls.Add(textKonfirmasiPassowrd);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JT-App";
            Load += FormRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtpassword2;
        private Label textKonfirmasiPassowrd;
        private CheckBox checkBoxTampilkanPassword;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button3;
        private TextBox txtNama;
        private Label label7;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtNo;
        private Label label9;
        private Label label2;
        private Label label10;
        private TextBox txtProvinsi;
        private TextBox txtKota;
        private PictureBox pictureBox1;
        private Label label1;
    }
}