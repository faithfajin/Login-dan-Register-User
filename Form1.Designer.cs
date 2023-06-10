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
            txtPassword = new TextBox();
            label3 = new Label();
            txtpassword2 = new TextBox();
            textKonfirmasiPassowrd = new Label();
            checkBoxTampilkanPassword = new CheckBox();
            button1 = new Button();
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
            label11 = new Label();
            LabelUsername = new Label();
            txtUsernamepilihan = new TextBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(390, 296);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 28);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(392, 277);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txtpassword2
            // 
            txtpassword2.Anchor = AnchorStyles.None;
            txtpassword2.BackColor = Color.FromArgb(230, 231, 233);
            txtpassword2.BorderStyle = BorderStyle.None;
            txtpassword2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword2.Location = new Point(390, 346);
            txtpassword2.Multiline = true;
            txtpassword2.Name = "txtpassword2";
            txtpassword2.PasswordChar = '*';
            txtpassword2.Size = new Size(300, 28);
            txtpassword2.TabIndex = 6;
            txtpassword2.TextChanged += txtpassword2_TextChanged;
            // 
            // textKonfirmasiPassowrd
            // 
            textKonfirmasiPassowrd.Anchor = AnchorStyles.None;
            textKonfirmasiPassowrd.AutoSize = true;
            textKonfirmasiPassowrd.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textKonfirmasiPassowrd.Location = new Point(392, 326);
            textKonfirmasiPassowrd.Name = "textKonfirmasiPassowrd";
            textKonfirmasiPassowrd.Size = new Size(153, 23);
            textKonfirmasiPassowrd.TabIndex = 5;
            textKonfirmasiPassowrd.Text = "Konfirmasi Password";
            textKonfirmasiPassowrd.Click += textKonfirmasiPassowrd_Click;
            // 
            // checkBoxTampilkanPassword
            // 
            checkBoxTampilkanPassword.Anchor = AnchorStyles.None;
            checkBoxTampilkanPassword.AutoSize = true;
            checkBoxTampilkanPassword.Cursor = Cursors.Hand;
            checkBoxTampilkanPassword.FlatStyle = FlatStyle.Flat;
            checkBoxTampilkanPassword.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxTampilkanPassword.Location = new Point(537, 379);
            checkBoxTampilkanPassword.Name = "checkBoxTampilkanPassword";
            checkBoxTampilkanPassword.Size = new Size(168, 27);
            checkBoxTampilkanPassword.TabIndex = 7;
            checkBoxTampilkanPassword.Text = "Tampilkan Password";
            checkBoxTampilkanPassword.UseVisualStyleBackColor = true;
            checkBoxTampilkanPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(55, 163, 165);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(390, 515);
            button1.Name = "button1";
            button1.Size = new Size(300, 35);
            button1.TabIndex = 8;
            button1.Text = "Daftar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(448, 562);
            label4.Name = "label4";
            label4.Size = new Size(147, 22);
            label4.TabIndex = 10;
            label4.Text = "Sudah Memiliki Akun?";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(55, 163, 165);
            label5.Location = new Point(593, 562);
            label5.Name = "label5";
            label5.Size = new Size(47, 22);
            label5.TabIndex = 11;
            label5.Text = "LOGIN";
            label5.Click += label5_Click;
            // 
            // txtNama
            // 
            txtNama.Anchor = AnchorStyles.None;
            txtNama.BackColor = Color.FromArgb(230, 231, 233);
            txtNama.BorderStyle = BorderStyle.None;
            txtNama.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(390, 92);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(300, 28);
            txtNama.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(389, 72);
            label7.Name = "label7";
            label7.Size = new Size(113, 23);
            label7.TabIndex = 13;
            label7.Text = "Nama Lengkap";
            label7.Click += label7_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = Color.FromArgb(230, 231, 233);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(390, 194);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 28);
            txtEmail.TabIndex = 16;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(392, 174);
            label8.Name = "label8";
            label8.Size = new Size(48, 23);
            label8.TabIndex = 15;
            label8.Text = "Email";
            label8.Click += label8_Click;
            // 
            // txtNo
            // 
            txtNo.Anchor = AnchorStyles.None;
            txtNo.BackColor = Color.FromArgb(230, 231, 233);
            txtNo.BorderStyle = BorderStyle.None;
            txtNo.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNo.Location = new Point(390, 246);
            txtNo.Multiline = true;
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(300, 28);
            txtNo.TabIndex = 18;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(392, 226);
            label9.Name = "label9";
            label9.Size = new Size(50, 23);
            label9.TabIndex = 17;
            label9.Text = "No Hp";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(393, 398);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 19;
            label2.Text = "Provinsi";
            label2.Click += label2_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(393, 449);
            label10.Name = "label10";
            label10.Size = new Size(41, 23);
            label10.TabIndex = 21;
            label10.Text = "Kota";
            // 
            // txtProvinsi
            // 
            txtProvinsi.Anchor = AnchorStyles.None;
            txtProvinsi.BackColor = Color.FromArgb(230, 231, 233);
            txtProvinsi.BorderStyle = BorderStyle.None;
            txtProvinsi.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProvinsi.Location = new Point(390, 418);
            txtProvinsi.Multiline = true;
            txtProvinsi.Name = "txtProvinsi";
            txtProvinsi.Size = new Size(300, 28);
            txtProvinsi.TabIndex = 22;
            // 
            // txtKota
            // 
            txtKota.Anchor = AnchorStyles.None;
            txtKota.BackColor = Color.FromArgb(230, 231, 233);
            txtKota.BorderStyle = BorderStyle.None;
            txtKota.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKota.Location = new Point(390, 469);
            txtKota.Multiline = true;
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(300, 28);
            txtKota.TabIndex = 23;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Poppins", 23.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(55, 163, 165);
            label11.Location = new Point(379, 22);
            label11.Name = "label11";
            label11.Size = new Size(189, 54);
            label11.TabIndex = 28;
            label11.Text = "Buat Akun";
            // 
            // LabelUsername
            // 
            LabelUsername.Anchor = AnchorStyles.None;
            LabelUsername.AutoSize = true;
            LabelUsername.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelUsername.Location = new Point(392, 123);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(80, 23);
            LabelUsername.TabIndex = 29;
            LabelUsername.Text = "Username";
            // 
            // txtUsernamepilihan
            // 
            txtUsernamepilihan.Anchor = AnchorStyles.None;
            txtUsernamepilihan.BackColor = Color.FromArgb(230, 231, 233);
            txtUsernamepilihan.BorderStyle = BorderStyle.None;
            txtUsernamepilihan.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsernamepilihan.Location = new Point(387, 143);
            txtUsernamepilihan.Multiline = true;
            txtUsernamepilihan.Name = "txtUsernamepilihan";
            txtUsernamepilihan.Size = new Size(300, 28);
            txtUsernamepilihan.TabIndex = 30;
            txtUsernamepilihan.TextChanged += txtUsernamepilihan_TextChanged;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 600);
            Controls.Add(txtUsernamepilihan);
            Controls.Add(LabelUsername);
            Controls.Add(label11);
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
            Controls.Add(button1);
            Controls.Add(checkBoxTampilkanPassword);
            Controls.Add(txtpassword2);
            Controls.Add(textKonfirmasiPassowrd);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JT-App";
            WindowState = FormWindowState.Maximized;
            Load += FormRegister_Load;
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
        private Label label4;
        private Label label5;
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
        private Label label11;
        private TextBox txtUsernamepilihan;
        private Label txtUsername;
        private TextBox textUsername;
        private Label LabelUsername;
        private TextBox textBox2;
    }
}