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
    public partial class MarketingAddForm : Form
    {
        private int mid = -1;
        public static SqlConnection mycon = null;
        DBconnection dbcon = new DBconnection();

        public MarketingAddForm()
        {
            InitializeComponent();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        //load table data to Grid view.
        private void loadGrid()
        {
            mycon = dbcon.setCon();

            string sql = "SELECT * FROM Marketing";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Marketing");

            showMarketingTableDataGridView.DataSource = ds.Tables["Marketing"];

            txtMDescription.Text = null;
            txtMcost.Text = null;
            txtSearch.Text = null;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "INSERT INTO Marketing " +
                "(Mdescription,Mcost,Mdate) " +
                "VALUES ('" + txtMDescription.Text + "', " + float.Parse(txtMcost.Text) + ", '" + MdateTimePicker.Value.Date + "')";

            SqlCommand cmd = new SqlCommand(sql, mycon);

            cmd.ExecuteNonQuery();

            MessageBox.Show("New Marketing Cost added successfull.");

            loadGrid();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "UPDATE Marketing SET " +
                "Mdescription = '" + txtMDescription.Text + "', " +
                "Mcost = " + float.Parse(txtMcost.Text) + ", " +
                "Mdate = '" + MdateTimePicker.Value.Date + "' " +
                "WHERE Mid = " + mid + " ";

            SqlCommand cmd = new SqlCommand(sql, mycon);

            cmd.ExecuteNonQuery();

            loadGrid();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void MarketingAddForm_Load(object sender, EventArgs e)
        {
            loadGrid();
        }


        private void btnMarketingSearchPB_Click(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();
            showMarketingTableDataGridView.DataSource = null;
            string sql = "SELECT * FROM Marketing WHERE Mdescription  = '" + txtSearch.Text + "' ";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Marketing");

            showMarketingTableDataGridView.DataSource = ds.Tables["Marketing"];

            txtSearch.Text = null;
        }

        private void ShowMarketingTableDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = showMarketingTableDataGridView.Rows[e.RowIndex];
                mid = (int)row.Cells[0].Value;
                txtMDescription.Text = row.Cells[1].Value.ToString();
                txtMcost.Text = row.Cells[2].Value.ToString();
                MdateTimePicker.Value = (DateTime)row.Cells[3].Value;
            }
        }
    }
}
