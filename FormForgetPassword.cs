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

        string CnS = "Host=localhost:5432;Username=postgres;Password=faith010304;Database=postgres";

        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(CnS))
            {
                connection.Open();
                {
                    if (txtEmail.Text != string.Empty)
                    {

                        NpgsqlCommand command = new NpgsqlCommand("select * from table_user where email='" + txtEmail.Text + "'", connection);
                        NpgsqlDataReader dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Silahkan cek email anda ", "Kode verifikasi terkirim");
                            FromCodeVerifikasi form2 = new FromCodeVerifikasi();
                            this.Close();
                            form2.Show();
                        }
                        else
                        {
                            dr.Close();
                            MessageBox.Show("Silahkan periksa kembali email anda ", "Gagal kirim Kode verifikasi terkirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Silahkan isi email anda.", "Gagal Kirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
    }
}
