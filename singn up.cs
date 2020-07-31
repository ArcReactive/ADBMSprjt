using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proj1
{
    public partial class singn_up : Form
    {
        public singn_up()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string uname1 = uname.Text;
            string pws = pass1.Text;
            string repass = pass2.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "INSERT INTO Table Values("+ uname1 +"," + pass1 + ","+ pass2 +")";
            SqlCommand cmd = new SqlCommand(qry, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted Successfuly");
            }
            catch (SqlException se)
            {
                MessageBox.Show("" + se);
            }

                this.Hide();
            Form1 k = new Form1();
            k.Show();
        }
    }
}
