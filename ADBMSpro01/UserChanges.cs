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
    public partial class UserChanges : Form
    {
        SqlConnection myCon = null;
        DBconnection dbcon = new DBconnection();

        private static string id = Confirmation.Uid;
        private static string privilage = Confirmation.Uprivilage;

        public UserChanges()
        {
            InitializeComponent();

            txtCurrent.PasswordChar = '*';
            txtNew.PasswordChar = '*';
            txtRe.PasswordChar = '*';
            
            //register the event handler.
            this.userManagetabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
        }

        private void back()
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        //Update password.
        private void userPassChange()
        {
            myCon = dbcon.setCon();
            string pass = txtNew.Text.ToString();

            string sql = "UPDATE users SET Upassword = '"+pass+"' WHERE Userid = "+id+"";

            SqlCommand cmd = new SqlCommand(sql, myCon);

            int c = cmd.ExecuteNonQuery();
            if (c != 0)
            {
                MessageBox.Show("Update Successfull.");
                clear();
            }
            else
            {
                MessageBox.Show("Update not Successfull.");
            }
        }

        private void clear()
        {
            txtCurrent.Text = null;
            txtNew.Text = null;
            txtRe.Text = null;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            myCon = dbcon.setCon();

            string sql = "SELECT COUNT(*) FROM Users WHERE Userid = " + int.Parse(id) + " AND Upassword = '" + txtCurrent.Text.ToString() + "' ";

            SqlDataAdapter sda = new SqlDataAdapter(sql, myCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                //matching new with re-enter.
                if (txtNew.Text.ToString() == txtRe.Text.ToString())
                {
                    userPassChange();
                }
                else
                {
                    MessageBox.Show("new-pasword is unmatched with re-password field.");
                    txtNew.Text = null;
                    txtRe.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Current Password is incorrect.");
                clear();
            }


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            back();
        }

        //control access tabs.
        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Check privilage.
            if ((privilage == "admin") && (userManagetabControl.SelectedTab == UserManageTab))
            {
                userManagetabControl.SelectedTab = UserManageTab;
            }
            else if ((privilage != "admin") && (userManagetabControl.SelectedTab == UserManageTab))
            {
                MessageBox.Show("Unable to load tab. You have insufficient access privileges.");
                userManagetabControl.SelectedTab = PassChangeTab;
            }
        }

        private void UserChanges_Load(object sender, EventArgs e)
        {
            
        }
    }
}
