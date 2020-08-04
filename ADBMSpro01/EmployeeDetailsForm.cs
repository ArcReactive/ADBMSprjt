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
                    Title = "EmplyeeCount",
                    LabelFormatter = value => value.ToString()
                });

                DR = null;
            }
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
    }
}
