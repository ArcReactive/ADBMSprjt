using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADBMSpro01
{
    public partial class EmployeeAddForm : Form
    {
        //Database connection.
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

        }

        //load data to grid
        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "SELECT * FROM Employee";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Employee"];

        }

        //update
        private void BtnNew_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        //save
        private void BtnSave_Click(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "INSERT INTO Employee (Efname,Elname,Ebod,Eregiterdate,Estatus) " +
                "VALUES ('"+ txtFname.Text +"', '"+ txtLname.Text +"', '"+ DOBTimePicker +"', '"+ RDTimePicker +"', 'Deactive')";

            SqlCommand cmd = new SqlCommand(sql, mycon);

            cmd.ExecuteNonQuery();

            MessageBox.Show("New Employee added successfull.");

        }

        private void TxtRD_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
        //search
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            showEmployeeTableDataGridView.DataSource = null;
            string sql = "SELECT * FROM Employee WHERE Efname = '"+txtSearch.Text+"'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Employee"];
        }

        //clear
        private void BtnClear_Click(object sender, EventArgs e)
        {
            
            string sql = "SELECT * FROM Employee";
            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Employee"];
        }

        //selection DataGridViewRow
        private void ShowEmployeeTableDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = showEmployeeTableDataGridView.Rows[e.RowIndex];
                txtFname.Text = row.Cells[1].Value.ToString();
                txtLname.Text = row.Cells[2].Value.ToString();
                txtDoB.Text = row.Cells[3].Value.ToString();
                txtRD.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
