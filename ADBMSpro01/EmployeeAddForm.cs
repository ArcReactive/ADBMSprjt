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
    public partial class EmployeeAddForm : Form
    {
        public static SqlConnection mycon = null;
        DBconnection dbcon = new DBconnection();

        public EmployeeAddForm()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {

            string sql = "SELECT * FROM Employee ";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Tables"];

            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    employeeBindingSource.RemoveCurrent();
                }
            }
        }

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "SELECT * FROM Employee";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Employee"];

            // TODO: This line of code loads data into the 'aDBMSpro1DataSet.Employee' table. You can move, or remove it, as needed.

            //this.employeeTableAdapter.Fill(this.aDBMSpro1DataSet.Employee);
            //employeeBindingSource.DataSource = this.aDBMSpro1DataSet.Employee;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    panel.Enabled = true;
            //    txtFname.Focus();
            //    //this.aDBMSpro1DataSet.Employee.AddEmployeeRow(this.aDBMSpro1DataSet.Employee.NewEmployeeRow());
            //    //employeeBindingSource.MoveLast();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //employeeBindingSource.ResetBindings(false);
            //}
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtFname.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                employeeBindingSource.EndEdit();
                employeeTableAdapter.Update(this.aDBMSpro1DataSet.Employee);
                panel.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeeBindingSource.ResetBindings(false);
            }
        }

        private void TxtRD_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.employeeTableAdapter.Fill(this.aDBMSpro1DataSet.Employee);
                    employeeBindingSource.DataSource = this.aDBMSpro1DataSet.Employee;
                    showEmployeeTableDataGridView.DataSource = employeeBindingSource;
                }
            }
        }

        private void TxtLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            showEmployeeTableDataGridView.DataSource = null;
            string sql = "SELECT * FROM Employee WHERE Efname = '"+txtSearch.Text+"'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Employee"];
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            
            string sql = "SELECT * FROM Employee";
            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Employee"];
        }
    }
}
