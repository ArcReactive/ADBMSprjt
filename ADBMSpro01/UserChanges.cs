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

        int uid = -1;
        string RadioStatus = null;
        string ComboPrivilage = null;

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
            txtName.Text = null;
            txtSearch.Text = null;
            txtPass.Text = null;
            privilageCBox.Text = null;
        }

        //load data.
        private void load()
        {
            myCon = dbcon.setCon();

            string sql = "SELECT * FROM Users";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, myCon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Users");

            UsersDataGridView.DataSource = ds.Tables["Users"];
        }

        //get radio btn.
        private void radioBtnSelection()
        {
            if (active.Checked)
            {
                RadioStatus = "active";
            }
            else if (deactive.Checked)
            {
                RadioStatus = "deactive";
            }
            else
            {
                MessageBox.Show("Set User Status.");
            }
        }

        //
        private void comboBoxSelection()
        {
            if (privilageCBox.SelectedItem != null)
            {
                ComboPrivilage = privilageCBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Set User privilage.");
            }
        }

        //password save.
        private void BtnSave_Click(object sender, EventArgs e)
        {

            myCon = dbcon.setCon();

            string sql = "SELECT COUNT(*) FROM Users WHERE Userid = " + int.Parse(id) + " AND Upassword = '" + txtCurrent.Text.ToString() + "' ";

            SqlDataAdapter sda = new SqlDataAdapter(sql, myCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                //ckeck empty.
                if (txtNew.Text != null && txtRe.Text != null)
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
                    MessageBox.Show("Empty field.");
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

                //load grid view.
                load();

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
        //new user save.
        private void BtnUserSave_Click(object sender, EventArgs e)
        {
            myCon = dbcon.setCon();

            //get value from combo.
            comboBoxSelection();

            //get radio btn.
            radioBtnSelection();

            //check status.
            if (RadioStatus != null && ComboPrivilage != null && txtName.Text != null && txtPass.Text != null)
            {
                string sql = "INSERT INTO Users (Uname,Upassword,Ustatus,Uprivilage) VALUES('" + txtName.Text.ToString() + "','" + txtPass.Text.ToString() + "','" + RadioStatus + "','" + ComboPrivilage + "')";

                SqlCommand cmd = new SqlCommand(sql, myCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("New User Details are added successfull.");

                load();
                clear();
                
            }
            else
            {
                MessageBox.Show("Empty field.");
            }

        }

        //update user details
        private void BtnUserUpdate_Click(object sender, EventArgs e)
        {
            myCon = dbcon.setCon();

            //get value from combo.
            comboBoxSelection();

            //get radio btn.
            radioBtnSelection();

            if (RadioStatus != null && ComboPrivilage != null && txtName.Text != null && txtPass.Text != null)
            {
                string sql = "UPDATE users SET Uname = '" + txtName.Text.ToString() + "', Upassword = '" + txtPass.Text.ToString() + "', Ustatus = '" + RadioStatus + "', Uprivilage = '"+ ComboPrivilage + "'  WHERE Userid = " + uid + "";

                SqlCommand cmd = new SqlCommand(sql, myCon);

                int c = cmd.ExecuteNonQuery();
                if (c != 0)
                {
                    MessageBox.Show("Update Successfull.");
                    clear();
                    load();
                }
                else
                {
                    MessageBox.Show("Update not Successfull.");
                }
            }
            else
            {
                MessageBox.Show("Empty field.");
            }
        }

        private void Active_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UsersDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string status = null;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = UsersDataGridView.Rows[e.RowIndex];
                uid = (int)row.Cells[0].Value;
                txtName.Text = row.Cells[1].Value.ToString();
                txtPass.Text = row.Cells[2].Value.ToString();
                privilageCBox.Text = row.Cells[4].Value.ToString();
                status = row.Cells[3].Value.ToString();
                //set radio btn.
                if (status == "active")
                {
                    active.Select();
                }
                else if (status == "deactive")
                {
                    deactive.Select();
                }

            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clear();
            load();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != null)
            {
                myCon = dbcon.setCon();

                string sql = "SELECT * FROM Users WHERE Uname = '" + txtSearch.Text.ToString() + "'";

                SqlDataAdapter sqlDA = new SqlDataAdapter(sql, myCon);
                DataSet ds = new DataSet();
                sqlDA.Fill(ds, "Users");

                UsersDataGridView.DataSource = ds.Tables["Users"];
            }
            else
            {
                MessageBox.Show("Empty search field.");
            }
        }
    }
}
