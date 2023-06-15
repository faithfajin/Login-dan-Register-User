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
            using (NpgsqlConnection connection = new NpgsqlConnection(CnS))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))

                {
                    // Disini saya membaca values inputan user
                    string namaLengkap = txtNama.Text;
                    string email = txtEmail.Text;
                    string noHp = txtNo.Text;
                    string password = txtPassword.Text;
                    string kota = txtKota.Text;
                    string provinsi = txtProvinsi.Text;
                    string username = txtUsernamepilihan.Text;

                    // Disini saya mengecek inputan kosong
                    if (string.IsNullOrEmpty(namaLengkap) || string.IsNullOrEmpty(email) ||
                        string.IsNullOrEmpty(noHp) || string.IsNullOrEmpty(username))
                    {
                        MessageBox.Show("Harap mengisi di semua kolom.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Disini saya mengecek bila inpuntan data dari user terdapat dalam database
                    string checkQuery = "SELECT COUNT(*) FROM table_user WHERE nama_lengkap = @nama_lengkap OR email = @email OR no_hp = @no_hp " +
                                        "OR username = @username";
                    using (NpgsqlCommand checkCommand = new NpgsqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("nama_lengkap", namaLengkap);
                        checkCommand.Parameters.AddWithValue("email", email);
                        checkCommand.Parameters.AddWithValue("username", username);
                        checkCommand.Parameters.AddWithValue("no_hp", noHp);

                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Name/Username/Email/Phone number Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNama.Text = "";
                            txtEmail.Text = "";
                            txtNo.Text = "";
                            txtUsernamepilihan.Text = "";
                            return;
                        }
                    }

                    // Disini bila tidak terdeteksi kesamaan dalam database maka lanjut menambah values paramater
                    command.Parameters.AddWithValue("nama_lengkap", namaLengkap);
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("no_hp", noHp);
                    command.Parameters.AddWithValue("password", password);
                    command.Parameters.AddWithValue("kota", kota);
                    command.Parameters.AddWithValue("provinsi", provinsi);
                    command.Parameters.AddWithValue("username", username);

                    try
                    {
                        // Disini saya mengeksekusi parameter sehingga data ditambahkan di database
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Akun Anda telah dibuat. Silakan login sekarang.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNama.Text = "";
                            txtEmail.Text = "";
                            txtNo.Text = "";
                            txtPassword.Text = "";
                            txtpassword2.Text = "";
                            txtKota.Text = "";
                            txtProvinsi.Text = "";
                            txtUsernamepilihan.Text = "";
                            this.Close();
                            new Formlogin().Show();
                        }
                        else
                        {
                            MessageBox.Show("Gagal membuat akun.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //Disini digunakan untuk menangani pengecualian yang terkait dengan koneksi dan operasi database yang menggunakan library Npgsql 
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("Telah terjadi kesalahan" + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}