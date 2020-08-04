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
    public partial class EmployeeDeacvtivateForm : Form
    {
        private int eid = -1;
        private String sts = "";

        public static SqlConnection mycon = null;
        DBconnection dbcon = new DBconnection();
        public EmployeeDeacvtivateForm()
        {
            InitializeComponent();
        }

        private void EmployeeDeacvtivateForm_Load(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "SELECT * FROM Employee";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Employee"];
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEmployeeSearchPB_Click(object sender, EventArgs e)
        {
            showEmployeeTableDataGridView.DataSource = null;
            string sql = "SELECT * FROM Employee WHERE Efname = '" + txtSearch.Text + "'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Employee"];
        }

        private void ShowEmployeeTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = showEmployeeTableDataGridView.Rows[e.RowIndex];
                eid = (int)row.Cells[0].Value;
                sts = (String)row.Cells[5].Value;
               
            }
        }

        private void BtnActivateDeactivateEmployee_Click(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "UPDATE Employee SET Estatus = 'active' WHERE Eid=" + eid + "";

            SqlCommand cmd = new SqlCommand(sql, mycon);


            cmd.ExecuteNonQuery();

            string sql2 = "SELECT * FROM Employee";
            SqlDataAdapter sqlDA = new SqlDataAdapter(sql2, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Employee"];
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "DELETE FROM Employee WHERE Eid=" + eid + "";

            SqlCommand cmd = new SqlCommand(sql, mycon);


            cmd.ExecuteNonQuery();

            string sql2 = "SELECT * FROM Employee";
            SqlDataAdapter sqlDA = new SqlDataAdapter(sql2, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Employee"];
        }

        private void BtnDeactivateEmployee_Click(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "UPDATE Employee SET Estatus = 'deactive' WHERE Eid=" + eid + "";

            SqlCommand cmd = new SqlCommand(sql, mycon);


            cmd.ExecuteNonQuery();

            string sql2 = "SELECT * FROM Employee";
            SqlDataAdapter sqlDA = new SqlDataAdapter(sql2, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Employee"];
        }
    }
}
