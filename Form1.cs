using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Proj1
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\Proj1\Logindb.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select count(*) from logintbl where username = '" + uname1.Text.Trim() + "' and password  ='" + pass.Text.Trim() + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            //con.Close();
            if(dt.Rows.Count == 1)
            {
                this.Hide();
                Home hh = new Home();
                hh.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            singn_up h = new singn_up();
            h.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordReset p = new PasswordReset();
            p.Show();
        }
    }
    }
    
            
        
    

