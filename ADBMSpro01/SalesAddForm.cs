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
    public partial class SalesAddForm : Form
    {
        //Database connection.
        public static SqlConnection myCon = null;
        DBconnection dbcon = new DBconnection();

        int id = -1;

        public SalesAddForm()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            myCon = dbcon.setCon();

            string sql = "SELECT * FROM Sales";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, myCon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Sales");

            SalesDataGridView.DataSource = ds.Tables["Sales"];
        }

        private void clear()
        {
            PnameTxt.Text = null;
            PqtyTxt.Text = null;
            PcostTxt.Text = null;
            SearchSalesTxt.Text = null;
        }

        private void SalesAddForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void SearchSalesPBox_Click(object sender, EventArgs e)
        {
            if (SearchSalesTxt.Text != null)
            {
                myCon = dbcon.setCon();

                string sql = "SELECT * FROM Sales WHERE Pname = '" + SearchSalesTxt.Text + "'";

                SqlDataAdapter sqlDA = new SqlDataAdapter(sql, myCon);
                DataSet ds = new DataSet();
                sqlDA.Fill(ds, "Sales");

                SalesDataGridView.DataSource = ds.Tables["Sales"];
            }
            else
            {
                MessageBox.Show("Empty search field.");
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (PnameTxt.Text != null && PqtyTxt.Text != null && PcostTxt.Text != null)
            {
                myCon = dbcon.setCon();

                string pname = PnameTxt.Text;
                int pqty = int.Parse(PqtyTxt.Text);
                float pcost = float.Parse(PcostTxt.Text);
                float ptotal = pqty * pcost;

                string sql = "UPDATE Sales SET " +
                    "Pname = '" + pname + "', " +
                    "Quantity = '" + pqty + "', " +
                    "Pcost = " + pcost + ", " +
                    "Total = " + ptotal + ", " +
                    "Sdate = '" + SdateDTP.Value.Date + "' " +
                    "WHERE Sid = " + id + "";

                SqlCommand cmd = new SqlCommand(sql, myCon);

                int c = cmd.ExecuteNonQuery();
                if (c != 0)
                {
                    MessageBox.Show("Sales Details Update Successfull.");
                }
                else
                {
                    MessageBox.Show("Sales Details NOT Update.");
                }

                loadData();
                clear();
            }
            else
            {
                MessageBox.Show("Empty field.");
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PnameTxt.Text != null && PqtyTxt.Text != null && PcostTxt.Text != null)
            {
                myCon = dbcon.setCon();

                string pname = PnameTxt.Text;
                int pqty = int.Parse(PqtyTxt.Text);
                float pcost = float.Parse(PcostTxt.Text);
                float ptotal = pqty * pcost;

                string sql = "INSERT INTO Sales " +
                    "(Pname,Quantity,Pcost,Total,Sdate) " +
                    "VALUES ('" + pname + "', " + pqty + ", " + pcost + ", " + ptotal + ", '" + SdateDTP.Value.Date + "')";

                SqlCommand cmd = new SqlCommand(sql, myCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("New Sales Details added successfull.");

                loadData();
                clear();
            }
            else
            {
                MessageBox.Show("Empty field.");
            }


        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            loadData();
            clear();
        }

        private void SalesDataGridView_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void SalesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = SalesDataGridView.Rows[e.RowIndex];
                id = (int)row.Cells[0].Value;
                PnameTxt.Text = row.Cells[1].Value.ToString();
                PqtyTxt.Text = row.Cells[2].Value.ToString();
                PcostTxt.Text = row.Cells[3].Value.ToString();
                SdateDTP.Value = (DateTime)row.Cells[5].Value;
            }
        }
    }
}
