using LiveCharts;
using LiveCharts.Wpf;
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
        SqlDataReader DR;

        int[] hours = { 0,0,0,0,0,0,0,0,0,0,0,0};
        int eid = -1;
        int i = 0;


        public EmployeeDetailsForm()
        {
            InitializeComponent();
        }

        private void EmployeeDetailsForm_Load(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();

            //string sql = "SELECT * FROM Employee";

            //SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            //DataSet ds = new DataSet();
            //sqlDA.Fill(ds, "Employee");

            mycon = dbcon.setCon();

            //1st chart showing registered employees per year
            using (mycon)
            {
               
                SqlCommand cmd = new SqlCommand("GetCountEmployeeRE", mycon);
                cmd.CommandType = CommandType.StoredProcedure;
                DR = cmd.ExecuteReader();


                ColumnSeries col = new ColumnSeries() { DataLabels = true, Values = new ChartValues<int>() };

                Axis ax = new Axis();

                ax.Labels = new List<string>();

                //int i = 0;
                while (DR.Read() /*&& i!=20*/)
                {
                    int value = (int)DR.GetInt32(0);
                    col.Values.Add(value);
                    int name = (int)DR.GetInt32(1);
                    ax.Labels.Add(name.ToString());
                    //i++;
                }
                employeesRegisteredPerYear.Series.Add(col);
                employeesRegisteredPerYear.AxisX.Add(ax);
                employeesRegisteredPerYear.AxisY.Add(new Axis
                {
                    Title = "EmployeeCount",
                    LabelFormatter = value => value.ToString()
                });

                DR.Close();
            }

            mycon = dbcon.setCon();

            //chart 2 showing count of active employees
            using (mycon)
            {

                SqlCommand cmd = new SqlCommand("GetActiveEmployeeCount", mycon);
                cmd.CommandType = CommandType.StoredProcedure;
                DR = cmd.ExecuteReader();

                ColumnSeries col = new ColumnSeries() { DataLabels = true, Values = new ChartValues<int>() };

                Axis ax = new Axis();

                ax.Labels = new List<string>();

                DR.Read();

                int val1 = (int)DR.GetInt32(0);
                col.Values.Add(val1);
                ax.Labels.Add("active");

                DR.Close();

                SqlCommand cmd1 = new SqlCommand("GetDeactiveEmployeeCount", mycon);
                cmd1.CommandType = CommandType.StoredProcedure;
                DR = cmd1.ExecuteReader();

                DR.Read();

                int val2 = (int)DR.GetInt32(0);
                col.Values.Add(val2);
                ax.Labels.Add("deactive");

                employeeStatusChart.Series.Add(col);
                employeeStatusChart.AxisX.Add(ax);
                employeeStatusChart.AxisY.Add(new Axis
                {
                    Title = "EmplyoeeCount",
                    LabelFormatter = value => value.ToString()
                });

                DR.Close();

            }

            //show Employee hours chart.

            EmpWorkingHoursChart.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            //set the Y axis.
            EmpWorkingHoursChart.AxisY.Add(new Axis
            {
                Title = "Hours",
                LabelFormatter = value => value.ToString()
            });


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void CartesianChart2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            mycon = dbcon.setCon();
            EmpNamesDataGridView.DataSource = null;
            string sql = "SELECT Eid, Efname, Elname FROM Employee WHERE Efname = '" + EmpSearchTxt.Text + "'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "Employee");

            EmpNamesDataGridView.DataSource = ds.Tables["Employee"];
        }

        private void EmpNamesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EmpWorkingHoursChart.Series.Clear();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = EmpNamesDataGridView.Rows[e.RowIndex];
                eid = (int)row.Cells[0].Value;
            }

            string sql = "select SUM(EWH) as total, MONTH(EWD)as month " +
                "from EmployeeWorkHours " +
                "WHERE Eid = "+eid+" " +
                "GROUP BY MONTH(EWD) " +
                "ORDER BY MONTH(EWD);";

            //set Data TOTAL chart
            mycon = dbcon.setCon();

            using (mycon)
            {
                //read sql.
                SqlCommand cmd = new SqlCommand(sql, mycon);
                i = 0;
                DR = cmd.ExecuteReader();
                using (DR)
                {
                    while (DR.Read())
                    {
                        int value = (int)DR.GetInt32(0);
                        hours[i] = value;
                        i++;
                    }
                }
                DR.Close();
            }

            //add series to chart.
            EmpWorkingHoursChart.Series = new LiveCharts.SeriesCollection
            {
                    new LineSeries
                    {
                        Values = new ChartValues<float> {
                            hours[0], hours[1], hours[2], hours[3], hours[4], hours[5], hours[6], hours[7], hours[8], hours[9], hours[10], hours[11]
                        }
                    },
            };

            //clear values.
            i = 0;
            while (i <= 11)
            {
                hours[i] = 0;
                i++;
            }
            i = 0;

        }
    }
}
