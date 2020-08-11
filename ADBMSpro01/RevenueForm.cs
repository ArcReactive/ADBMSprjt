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
    public partial class RevenueForm : Form
    {
        public static SqlConnection myCon = null;
        SqlDataReader DR;

        float[] revenueValue = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        float[] Dash_salesValue = DashboardForm.salesValue;
        float[] DashB_costValue = DashboardForm.costValue;

        public RevenueForm()
        {
            InitializeComponent();
        }

        private void RevenueForm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i<12; i++)
            {
                revenueValue[i] = Dash_salesValue[i] - DashB_costValue[i];
            }

            //add two series to chart.
            RevenueCartesianChart.Series = new LiveCharts.SeriesCollection
            {

                    new LineSeries
                    {
                        Title = "Revenue",
                        Values = new ChartValues<float> {
                            revenueValue[0], revenueValue[1], revenueValue[2], revenueValue[3], revenueValue[4], revenueValue[5], revenueValue[6], revenueValue[7],revenueValue[8], revenueValue[9], revenueValue[10], revenueValue[11]
                        }

                    },
                };
            //set the X axis.
            RevenueCartesianChart.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            //set the Y axis.
            RevenueCartesianChart.AxisY.Add(new Axis
            {
                Title = "Price",
                LabelFormatter = value => value.ToString("C")
            });

            RevenueCartesianChart.LegendLocation = LegendLocation.Right;

        }
    }
}
