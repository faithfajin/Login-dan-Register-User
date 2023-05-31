using Login_dan_Register_Project_PBO_A;

namespace DesktopApp
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" & txtPassword.Text == "123")
            {
                new dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah, Silahkan coba lagi", "Login Gagal", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
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
    }
}
