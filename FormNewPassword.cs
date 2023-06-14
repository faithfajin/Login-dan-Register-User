﻿using DesktopApp;

namespace Login_dan_Register_Project_PBO_A
{
    public partial class FormNewPassword : Form
    {
        public FormNewPassword()
        {
            InitializeComponent();
        }

        private void checkBoxTampilkanPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTampilkanPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtpassword2.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtpassword2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtpassword2.Text)
            {
                this.Close();
                new Formlogin().Show();
                MessageBox.Show("Password telah direset", "Reset password berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password tidak sama, Silahkan memasukan kembali password", "Daftar Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtpassword2.Text = "";
                txtPassword.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                button2.BringToFront();
                txtPassword.PasswordChar = '*';

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                button3.BringToFront();
                txtPassword.PasswordChar = '\0';

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                button4.BringToFront();
                txtpassword2.PasswordChar = '\0';

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                button5.BringToFront();
                txtpassword2.PasswordChar = '*';

            }
        }
    }
}
