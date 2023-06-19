using Npgsql;

namespace DesktopApp
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        string CnS = "Host=localhost:5432;Username=postgres;Password=faith010304;Database=postgres";


        string insertQuery = "INSERT INTO table_user (username, nama_lengkap, email, no_hp, password, kota, provinsi) " +
                     "VALUES (@username, @nama_lengkap, @email, @no_hp, @password, @kota, @provinsi)";



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            new Formlogin().Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpassword2.Text != txtPassword.Text)
            {
                MessageBox.Show("Konfirmasi kata sandi tidak cocok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword2.Text = "";
                return;
            }

            string namaLengkap = txtNama.Text;
            string email = txtEmail.Text;
            string noHp = txtNo.Text;
            string password = txtPassword.Text;
            string kota = txtKota.Text;
            string provinsi = txtProvinsi.Text;
            string username = txtUsernamepilihan.Text;

            if (string.IsNullOrEmpty(namaLengkap) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(noHp) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Harap mengisi semua kolom.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Kata sandi harus memiliki minimal 6 karakter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (noHp.Length > 20)
            {
                MessageBox.Show("Nomor telepon tidak boleh lebih dari 20 karakter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int parsedNoHp;
            if (!int.TryParse(noHp, out parsedNoHp))
            {
                MessageBox.Show("Nomor telepon harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(CnS))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("nama_lengkap", namaLengkap);
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("no_hp", parsedNoHp);
                    command.Parameters.AddWithValue("password", password);
                    command.Parameters.AddWithValue("kota", kota);
                    command.Parameters.AddWithValue("provinsi", provinsi);
                    command.Parameters.AddWithValue("username", username);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Akun Anda telah dibuat. Silakan login sekarang.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            new Formlogin().Show();
                        }
                        else
                        {
                            MessageBox.Show("Gagal membuat akun.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("Telah terjadi kesalahan: " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void txtpassword2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textKonfirmasiPassowrd_Click(object sender, EventArgs e)
        {
        }

        private void txtUsernamepilihan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtPassword.PasswordChar == '\0')
            {
                button4.BringToFront();
                txtPassword.PasswordChar = '*';

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (txtPassword.PasswordChar == '*')
            {
                button2.BringToFront();
                txtPassword.PasswordChar = '\0';

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (txtpassword2.PasswordChar == '\0')
            {
                button6.BringToFront();
                txtpassword2.PasswordChar = '*';

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (txtpassword2.PasswordChar == '*')
            {
                button5.BringToFront();
                txtpassword2.PasswordChar = '\0';

            }

        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}