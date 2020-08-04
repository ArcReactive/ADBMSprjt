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
//author NuwanSudusinghe.
namespace ADBMSpro01
{
    public partial class MarketingDetailsForm : Form
    {

        public static SqlConnection myCon = null;
        SqlDataReader DR;

        float[] costValue = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        //connection.
        DBconnection dbcon = new DBconnection();

        public MarketingDetailsForm()
        {
            InitializeComponent();
        }

        private void MarketingDetailsForm_Load(object sender, EventArgs e)
        {
            myCon = dbcon.setCon();

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

            //add series to chart.
            MarketingMonthChart.Series = new LiveCharts.SeriesCollection
            {
                    new LineSeries
                    {
                        Title = "Cost",
                        Values = new ChartValues<double> {
                            costValue[0], costValue[1], costValue[2], costValue[3], costValue[4], costValue[5], costValue[6], costValue[7], costValue[8], costValue[9], costValue[10], costValue[11]
                        }
                    },
                };
            //set the X axis.
            MarketingMonthChart.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            //set the Y axis.
            MarketingMonthChart.AxisY.Add(new Axis
            {
                Title = "Price",
                LabelFormatter = value => value.ToString("C")
            });

            MarketingMonthChart.LegendLocation = LegendLocation.Right;


        }
    }
}
