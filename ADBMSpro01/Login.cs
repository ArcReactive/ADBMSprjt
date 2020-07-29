using System;
using System.Windows.Forms;

namespace ADBMSpro01
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
