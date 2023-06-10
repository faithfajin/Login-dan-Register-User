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
                    //if (txtPassword.Text != string.Empty || txtUsername.Text != string.Empty)
                    //{

                    //    NpgsqlCommand command = new NpgsqlCommand("select * from table_user where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", connection);
                    //    NpgsqlDataReader dr = command.ExecuteReader();
                    //    if (dr.Read())
                    //    {
                    //        string getIdQuery = "SELECT lastval()";
                    //        using (NpgsqlCommand getIdCommand = new NpgsqlCommand(getIdQuery, connection))
                    //        {
                    //            userId = Convert.ToInt32(getIdCommand.ExecuteScalar());
                    //        }
                    //        MessageBox.Show("Selemat datang ", "login berhasil");
                    //        dashboard form2 = new dashboard();
                    //        form2.Show();
                    //        this.Hide();
                    //    }
                    //    else
                    //    {
                    //        dr.Close();
                    //        MessageBox.Show("Silahkan periksa kembali username and password ", "Gagal login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Silahkan isi username dan password.", "Gagal login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
            }
        }

        private void checkBoxTampilkanPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTampilkanPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormForgetPassword().Show();
        }
    }
}
