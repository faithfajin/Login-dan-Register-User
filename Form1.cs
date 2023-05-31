namespace DesktopApp
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }


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
            if (txtNama.Text == "" || txtEmail.Text == "" || txtNo.Text == "" || txtPassword.Text == "" || txtpassword2.Text == "" || txtProvinsi.Text == "" || txtKota.Text == "")
            {
                MessageBox.Show("Silahkan lengkapi data anda", "Daftar Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtpassword2.Text)
            {
                txtNama.Text = "";
                txtEmail.Text = "";
                txtNo.Text = "";
                txtPassword.Text = "";
                txtpassword2.Text = "";
                txtProvinsi.Text = "";
                txtKota.Text = "";

                MessageBox.Show("Silahkan Tunggu Konfirmasi", "Daftar berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password tidak sama, Silahkan memasukan kembali password", "Daftar Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtpassword2.Text = "";
                txtPassword.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtEmail.Text = "";
            txtNo.Text = "";
            txtPassword.Text = "";
            txtpassword2.Text = "";
            txtProvinsi.Text = "";
            txtKota.Text = "";
            txtNama.Focus();
        }
    }
}