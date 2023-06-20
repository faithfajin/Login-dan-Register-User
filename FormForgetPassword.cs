using DesktopApp;
using Npgsql;

namespace Login_dan_Register_Project_PBO_A
{
    public partial class FormForgetPassword : Form
    {
        public FormForgetPassword()
        {
            InitializeComponent();
        }

        private string generatedCode;
        string CnS = "Host=localhost;Port=5432;Username=postgres;Password=faith010304;Database=JT-app";

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Kode tidak boleh kosong.", "Kesalahan");
                    return;
                }

                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Username tidak boleh kosong.", "Kesalahan");
                    return;
                }
                if (textBox1.Text == generatedCode)
                {
                    if (CheckUsernameCodeMatch(txtEmail.Text, generatedCode))
                    {
                        // Jika sesuai, pindah ke form selanjutnya
                        this.Hide();
                        FormNewPassword formNewPassword = new FormNewPassword();
                        formNewPassword.SetUsername(txtEmail.Text);
                        formNewPassword.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username atau kode yang Anda masukkan salah. Silakan coba lagi.", "Kesalahan");
                    }
                }
                else
                {
                    // Jika tidak sesuai, tampilkan pesan kesalahan
                    MessageBox.Show("Kode yang Anda masukkan salah. Silakan coba lagi.", "Kesalahan");
                }
            }

        }

        private bool CheckUsernameCodeMatch(string username, string generatedCode)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(CnS))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT COUNT(*) FROM \"User\" WHERE email = @email";
                        command.Parameters.AddWithValue("@email", username);
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0; // Mengembalikan true jika username dan kode cocok
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            new Formlogin().Show();
        }

        private void FormForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Menghasilkan angka acak dengan 4 digit
            Random random = new Random();
            int angka = random.Next(1000, 9999);

            // Menyimpan angka yang dihasilkan ke dalam variabel generatedCode
            generatedCode = angka.ToString();

            // Menampilkan angka acak di TxtCode
            txtcode.Text = generatedCode;
        }
        public void SetUsername(string username)
        {
            txtUsername.Text = username;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
