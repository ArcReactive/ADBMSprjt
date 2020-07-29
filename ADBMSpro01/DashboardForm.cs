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
//author @NuwanSudusinghe
namespace ADBMSpro01
{
    public partial class DashboardForm : Form
    {
        public static SqlConnection myCon = null;
        SqlDataReader DR;

        float[] salesValue = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        float[] costValue = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

            //SALES and COST chart.

            //connection.
            DBconnection dbcon = new DBconnection();
            myCon = dbcon.setCon();

            //set sales.
            using (myCon)
            {
                //read store procedure.
                SqlCommand cmd = new SqlCommand("GetSalesTotalByMonth", myCon);

                cmd.CommandType = CommandType.StoredProcedure;

                DR = cmd.ExecuteReader();
                int i = 0;
                using (DR)
                {
                    while (DR.Read())
                    {
                        float value = (float)DR.GetDouble(0);
                        salesValue[i] = value;
                        i++;
                    }
                }
                DR = null;
            }

            //set cost.
            myCon = dbcon.setCon();

            using (myCon)
            {
                //read store procedure.
                SqlCommand cmd1 = new SqlCommand("GetCostTotalByMonth", myCon);

                cmd1.CommandType = CommandType.StoredProcedure;

                DR = cmd1.ExecuteReader();
                int i = 0;
                using (DR)
                {
                    while (DR.Read())
                    {
                        float value = (float)DR.GetDouble(0);
                        costValue[i] = value;
                        i++;
                    }
                }
                DR = null;
            }

            //add two series to chart.
            SalesChart.Series = new LiveCharts.SeriesCollection
            {

                    new LineSeries
                    {
                        Title = "Sales",
                        Values = new ChartValues<float> {
                            salesValue[0], salesValue[1], salesValue[2], salesValue[3], salesValue[4], salesValue[5], salesValue[6], salesValue[7], salesValue[8], salesValue[9], salesValue[10], salesValue[11]
                        }

                    },
                    new LineSeries
                    {
                        Title = "Cost",
                        Values = new ChartValues<double> {
                            costValue[0], costValue[1], costValue[2], costValue[3], costValue[4], costValue[5], costValue[6], costValue[7], costValue[8], costValue[9], costValue[10], costValue[11]
                        }
                    },
                };
            //set the X axis.
            SalesChart.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            //set the Y axis.
            SalesChart.AxisY.Add(new Axis
            {
                Title = "Price",
                LabelFormatter = value => value.ToString("C")
            });

            SalesChart.LegendLocation = LegendLocation.Right;


            //ALL PRODUCTS chart.
            myCon = dbcon.setCon();

            using (myCon)
            {

                SqlCommand cmd1 = new SqlCommand("GetAllProductThisMonth", myCon);
                cmd1.CommandType = CommandType.StoredProcedure;
                DR = cmd1.ExecuteReader();


                ColumnSeries col = new ColumnSeries() { DataLabels = true, Values = new ChartValues<int>() };

                Axis ax = new Axis();

                ax.Labels = new List<string>();

                //int i = 0;
                while (DR.Read() /*&& i!=20*/)
                {
                    int value = (int)DR.GetInt32(1);
                    col.Values.Add(value);
                    String name = (String)DR.GetString(0);
                    ax.Labels.Add(name);
                    //i++;
                }
                AllproductChart.Series.Add(col);
                AllproductChart.AxisX.Add(ax);
                AllproductChart.AxisY.Add(new Axis
                {
                    Title = "QTY",
                    LabelFormatter = value => value.ToString()
                });

                DR = null;
            }
        }
    }
}
