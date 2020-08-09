using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADBMSpro01
{
    public partial class Login : Form
    {
        public static string Uname = null;
        public static string Uprivilage = null;

        public Login()
        {
            InitializeComponent();
            PasswordTxt.PasswordChar = '*';
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

            SqlConnection myCon = null;
            DBconnection dbcon = new DBconnection();

            myCon = dbcon.setCon();

            string sql = "SELECT COUNT(*) FROM Users WHERE Uname = '"+UsernameTxt.Text.ToString()+"' AND Upassword = '"+PasswordTxt.Text.ToString()+"' ";

            SqlDataAdapter sda = new SqlDataAdapter(sql,myCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                string sqlGet = "SELECT * FROM Users WHERE Uname = '" + UsernameTxt.Text.ToString() + "' AND Upassword = '" + PasswordTxt.Text.ToString() + "' ";

                SqlDataAdapter sda1 = new SqlDataAdapter(sqlGet, myCon);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);

                foreach (DataRow row in dt1.Rows)
                {
                    Uname = row["Uname"].ToString();
                    Uprivilage = row["Uprivilage"].ToString();
                }


                //MessageBox.Show(privilage+" "+user);

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
                //LoadingForm lf = new LoadingForm();
                //lf.Show();
                //this.Hide();

            }
            else
            {
                MessageBox.Show("Username OR Password is incorrect.");
            }

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterPB_Click(object sender, EventArgs e)
        {
            Confirmation c = new Confirmation();
            c.Show();
            this.Hide();
        }
    }
}
