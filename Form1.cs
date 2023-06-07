using Npgsql;

namespace DesktopApp
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        string CnS = "Host=localhost:5432;Username=postgres;Password=010304;Database=postgres";


        string insertQuery = "INSERT INTO data_user (nama_lengkap, username_pilihan, email, no_hp, password, kota, provinsi) " +
                     "VALUES (@nama_lengkap, @username_pilihan, @email, @no_hp, @password, @kota, @provinsi)";



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {
            new Formlogin().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(CnS))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    // Get values from TextBoxes
                    string namaLengkap = txtNama.Text;
                    string email = txtEmail.Text;
                    string noHp = txtNo.Text;
                    string password = txtPassword.Text;
                    string kota = txtKota.Text;
                    string provinsi = txtProvinsi.Text;
                    string username = txtUsernamepilihan.Text;

                    // parameter values
                    command.Parameters.AddWithValue("nama_lengkap", namaLengkap);
                    command.Parameters.AddWithValue("username_pilihan", username);
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("no_hp", noHp);
                    command.Parameters.AddWithValue("password", password);
                    command.Parameters.AddWithValue("kota", kota);
                    command.Parameters.AddWithValue("provinsi", provinsi);

                    // input kosong
                    if (string.IsNullOrEmpty(namaLengkap) || string.IsNullOrEmpty(email) ||
                        string.IsNullOrEmpty(noHp) || string.IsNullOrEmpty(password) ||
                        string.IsNullOrEmpty(kota) || string.IsNullOrEmpty(provinsi) || string.IsNullOrEmpty(username))
                    {
                        MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        // Eksekusi
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNama.Text = "";
                            txtUsernamepilihan.Text = "";
                            txtEmail.Text = "";
                            txtNo.Text = "";
                            txtPassword.Text = "";
                            txtpassword2.Text = "";
                            txtProvinsi.Text = "";
                            txtKota.Text = "";
                            txtNama.Focus();


                        }
                        else
                        {

                            MessageBox.Show("Your Account is not created . Please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        if (ex.SqlState == "23505" && (password != "" || kota != "" || provinsi != ""))
                        {
                            MessageBox.Show("Name/Username/Email/Phone number Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNama.Text = "";
                            txtEmail.Text = "";
                            txtNo.Text = "";
                            txtNama.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Sistem Error ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
    }
}