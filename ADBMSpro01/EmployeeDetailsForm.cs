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
    public partial class EmployeeDetailsForm : Form
    {
        public static SqlConnection mycon = null;
        DBconnection dbcon = new DBconnection();

        public EmployeeDetailsForm()
        {
            InitializeComponent();
        }

        private void EmployeeDetailsForm_Load(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "SELECT * FROM Employee";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Employee"];
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowEmployeeTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
