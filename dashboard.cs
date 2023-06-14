using DesktopApp;

namespace Login_dan_Register_Project_PBO_A
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            string username = Formlogin.TempUsername;
            string password = Formlogin.TempPassword;

            MessageBox.Show($"Username: {username}\nPassword: {password}", "Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
