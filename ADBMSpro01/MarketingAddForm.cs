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
        private float cost = (float)txtMcost.TEXT;
        public static SqlConnection mycon = null;
        DBconnection dbcon = new DBconnection();

        public MarketingAddForm()
        {
            InitializeComponent();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "INSERT INTO Marketing " +
                "(Mdescription,Mcost,Mdate) " +
                "VALUES ('" + txtMDescription.Text + "', '" + txtMcost.Text + "', '" + MdateTimePicker.Value.Date + "')";

            SqlCommand cmd = new SqlCommand(sql, mycon);

            cmd.ExecuteNonQuery();

            MessageBox.Show("New Marketing added successfull.");

            string sql1 = "SELECT * FROM Marketing";
            SqlDataAdapter sqlDA = new SqlDataAdapter(sql1, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Marketing");

            showMarketingTableDataGridView.DataSource = ds.Tables["Marketing"];
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "UPDATE Marketing SET " +
                "Mdescription='" + txtMDescription.Text + "', " +
                "Mcost='" + txtMcost.Text + "', " +
                "Mdate='" + MdateTimePicker.Value.Date + "', " +
                "WHERE Mid =" + mid + "";

            SqlCommand cmd = new SqlCommand(sql, mycon);


            cmd.ExecuteNonQuery();

            string sql2 = "SELECT * FROM Marketing";
            SqlDataAdapter sqlDA = new SqlDataAdapter(sql2, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Marketing");

            showMarketingTableDataGridView.DataSource = ds.Tables["Marketing"];
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Marketing";
            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Marketing");

            showMarketingTableDataGridView.DataSource = ds.Tables["Marketing"];
        }

        private void MarketingAddForm_Load(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            string sql = "SELECT * FROM Marketing";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Marketing");

            showMarketingTableDataGridView.DataSource = ds.Tables["Marketing"];
        }


        private void btnMarketingSearchPB_Click(object sender, EventArgs e)
        {
            showMarketingTableDataGridView.DataSource = null;
            string sql = "SELECT * FROM Marketing WHERE Mdescription  = '" + txtMDescription.Text + "'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Marketing");

            showMarketingTableDataGridView.DataSource = ds.Tables["Marketing"];
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
