namespace Login_dan_Register_Project_PBO_A
{
    public partial class FromCodeVerifikasi : Form
    {
        public FromCodeVerifikasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "010304")
            {
                this.Close();
                new FormNewPassword().Show();
                MessageBox.Show("Kode benar", "Verifikasi berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kode salah, Silahkan memasukan kembali kode", "Verifikasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Text = "";
                txtCode.Focus();
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void FromCodeVerifikasi_Load(object sender, EventArgs e)
        {

        }
    }
}
