using DesktopApp;
using Npgsql;

namespace Login_dan_Register_Project_PBO_A
{
    public partial class FormNewPassword : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=faith010304;Database=JT-app";
        private string username;
        public FormNewPassword()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            if (txtPassword.Text == txtpassword2.Text)
            {

                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();
                        using (NpgsqlCommand command = new NpgsqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = $"UPDATE \"User\" SET kata_sandi = '{password}' WHERE email = '{username}'";
                            command.ExecuteNonQuery();
                        }
                    }

                    this.Close();
                    new Formlogin().Show();
                    MessageBox.Show("Password telah direset", "Reset password berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            if (txtPassword.PasswordChar == '*')
            {
                button2.BringToFront();
                txtPassword.PasswordChar = '\0';

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                button3.BringToFront();
                txtPassword.PasswordChar = '*';

            }
        }


        private void FormNewPassword_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (txtpassword2.PasswordChar == '*')
            {
                button4.BringToFront();
                txtpassword2.PasswordChar = '\0';

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (txtpassword2.PasswordChar == '\0')
            {
                button5.BringToFront();
                txtpassword2.PasswordChar = '*';

            }
        }

        internal void SetUsername(string username)
        {
            this.username = username;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
