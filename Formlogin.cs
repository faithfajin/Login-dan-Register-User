using Login_dan_Register_Project_PBO_A;
using Npgsql;
namespace DesktopApp
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private int userId; // Variabel untuk menyimpan ID pengguna
        string CnS = "Host=localhost:5432;Username=postgres;Password=faith010304;Database=postgres";
        string selectQuery = "SELECT id FROM table_user WHERE username = @username AND password = @password";
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
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    // ngecek empty input
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Please enter a username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // ngeset parameter values
                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("password", password);

                    try
                    {
                        // eksekuasi query
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);

                            MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear TextBoxes
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            this.Hide();
                            new dashboard().Show();

                        }
                        else
                        {
                            MessageBox.Show("Silahkan periksa kembali username and password ", "Gagal login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
