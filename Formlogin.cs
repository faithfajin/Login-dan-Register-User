using Login_dan_Register_Project_PBO_A;
using Npgsql;
namespace DesktopApp
{

    public partial class Formlogin : Form
    {
        public static string TempEmail { get; private set; }
        public static string TempPassword { get; private set; }

        public Formlogin()
        {
            InitializeComponent();
        }

        private int userId; // Variabel untuk menyimpan ID pengguna
        string CnS = "Host=localhost;Port=5432;Username=postgres;Password=faith010304;Database=JT-Apps";
        string selectQuery = "SELECT user_id FROM \"User\" WHERE (email = email Or nama_lengkap = nama_lengkap) AND kata_sandi = @kata_sandi";
        private void Formlogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegister().Show();
        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(CnS))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    // Get values 
                    string email = txtEmail.Text;
                    string password = txtPassword.Text;

                    // ngecek empty input
                    if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Please enter your email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // ngeset parameter values
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("kata_sandi", password);

                    try
                    {
                        // eksekuasi query
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            TempEmail = email;
                            TempPassword = password;


                            userId = Convert.ToInt32(result);

                            MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear TextBoxes
                            txtEmail.Text = "";
                            txtPassword.Text = "";
                            this.Hide();
                            new dashboard().Show();

                        }
                        else
                        {
                            MessageBox.Show("Silahkan periksa kembali email and password ", "Gagal login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormForgetPassword().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                button3.BringToFront();
                txtPassword.PasswordChar = '*';
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
    }
}
