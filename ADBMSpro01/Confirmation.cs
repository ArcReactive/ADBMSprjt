using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADBMSpro01
{
    public partial class Confirmation : Form
    {
        //public static string Uname = null;
        public static string Uprivilage = null;
        public static string Uid = null;

        public Confirmation()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = null;
            DBconnection dbcon = new DBconnection();

            myCon = dbcon.setCon();

            string sql = "SELECT COUNT(*) FROM Users WHERE Uname = '" + txtUseName.Text.ToString() + "' AND Upassword = '" + txtPassword.Text.ToString() + "' ";

            SqlDataAdapter sda = new SqlDataAdapter(sql, myCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                string sqlGet = "SELECT * FROM Users WHERE Uname = '" + txtUseName.Text.ToString() + "' AND Upassword = '" + txtPassword.Text.ToString() + "' ";

                SqlDataAdapter sda1 = new SqlDataAdapter(sqlGet, myCon);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);

                foreach (DataRow row in dt1.Rows)
                {
                    Uid = row["Userid"].ToString();
                    //Uname = row["Uname"].ToString();
                    Uprivilage = row["Uprivilage"].ToString();
                }

                UserChanges uc = new UserChanges();
                uc.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username OR Password is incorrect.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
