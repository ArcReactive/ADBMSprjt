using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADBMSpro01
{
    public partial class EmployeeAddForm : Form
    {
        private int eid = -1;
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        //save
        private void BtnSave_Click(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "INSERT INTO Employee (Efname,Elname,Ebod,Eregiterdate,Estatus) " +
                "VALUES ('"+ txtFname.Text +"', '"+ txtLname.Text +"', '"+ DOBTimePicker.Value.Date +"', '"+ RDTimePicker.Value.Date +"', 'Deactive')";

            SqlCommand cmd = new SqlCommand(sql, mycon);

            cmd.ExecuteNonQuery();

            MessageBox.Show("New Employee added successfull.");

            string sql1 = "SELECT * FROM Employee";
            SqlDataAdapter sqlDA = new SqlDataAdapter(sql1, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            showEmployeeTableDataGridView.DataSource = ds.Tables["Employee"];

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
                eid = (int)row.Cells[0].Value;
                txtFname.Text = row.Cells[1].Value.ToString();
                txtLname.Text = row.Cells[2].Value.ToString();
                DOBTimePicker.Value = (DateTime)row.Cells[3].Value;
                RDTimePicker.Value = (DateTime)row.Cells[4].Value;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();



            //string sql = "UPDATE Employee (Efname,Elname,Ebod,Eregiterdate) " +
            //    "VALUES ('" + txtFname.Text + "', '" + txtLname.Text + "', '" + DOBTimePicker.Value.Date + "', '" + RDTimePicker.Value.Date + "') " +
            //    "WHERE Eid = eid";

            string sql = "UPDATE Employee SET Efname='"+txtFname.Text+"', Elname='"+txtLname.Text+"', Ebod='"+DOBTimePicker.Value.Date+"', Eregiterdate='"+RDTimePicker.Value.Date+"' WHERE Eid="+eid+"";

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
