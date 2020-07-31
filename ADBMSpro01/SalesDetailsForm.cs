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
    public partial class SalesDetailsForm : Form
    {

        public static SqlConnection myCon = null;
        SqlDataReader DR;

        String p1 = null, p2 = null, p3 = null, p4 = null, p5 = null;

        int[] pro1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] pro2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] pro3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] pro4 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] pro5 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public SalesDetailsForm()
        {
            InitializeComponent();
        }

        private void SalesDetailsForm_Load(object sender, EventArgs e)
        {
            //TOP 5 products monthly sales.

            //connection.
            DBconnection dbcon = new DBconnection();
            myCon = dbcon.setCon();

            //set product 1.
            using (myCon)
            {
                //read store procedure.
                SqlCommand cmd = new SqlCommand("GetRow1Pro", myCon);

                cmd.CommandType = CommandType.StoredProcedure;

                DR = cmd.ExecuteReader();
                int i = 0;
                using (DR)
                {
                    while (DR.Read())
                    {
                        p1 = (String)DR.GetString(0);
                        int value = (int)DR.GetInt32(1);
                        pro1[i] = value;
                        i++;
                    }
                }
                DR = null;
            }

            //set product 2.
            myCon = dbcon.setCon();
            using (myCon)
            {
                //read store procedure.
                SqlCommand cmd = new SqlCommand("GetRow2Pro", myCon);

                cmd.CommandType = CommandType.StoredProcedure;

                DR = cmd.ExecuteReader();
                int i = 0;
                using (DR)
                {
                    while (DR.Read())
                    {
                        p2 = (String)DR.GetString(0);
                        int value = (int)DR.GetInt32(1);
                        pro2[i] = value;
                        i++;
                    }
                }
                DR = null;
            }

            //set product 3.
            myCon = dbcon.setCon();
            using (myCon)
            {
                //read store procedure.
                SqlCommand cmd = new SqlCommand("GetRow3Pro", myCon);

                cmd.CommandType = CommandType.StoredProcedure;

                DR = cmd.ExecuteReader();
                int i = 0;
                using (DR)
                {
                    while (DR.Read())
                    {
                        p3 = (String)DR.GetString(0);
                        int value = (int)DR.GetInt32(1);
                        pro3[i] = value;
                        i++;
                    }
                }
                DR = null;
            }

            //set product 4.
            myCon = dbcon.setCon();
            using (myCon)
            {
                //read store procedure.
                SqlCommand cmd = new SqlCommand("GetRow4Pro", myCon);

                cmd.CommandType = CommandType.StoredProcedure;

                DR = cmd.ExecuteReader();
                int i = 0;
                using (DR)
                {
                    while (DR.Read())
                    {
                        p4 = (String)DR.GetString(0);
                        int value = (int)DR.GetInt32(1);
                        pro4[i] = value;
                        i++;
                    }
                }
                DR = null;
            }

            //set product 5.
            myCon = dbcon.setCon();
            using (myCon)
            {
                //read store procedure.
                SqlCommand cmd = new SqlCommand("GetRow5Pro", myCon);

                cmd.CommandType = CommandType.StoredProcedure;

                DR = cmd.ExecuteReader();
                int i = 0;
                using (DR)
                {
                    while (DR.Read())
                    {
                        p5 = (String)DR.GetString(0);
                        int value = (int)DR.GetInt32(1);
                        pro5[i] = value;
                        i++;
                    }
                }
                DR = null;
            }

            //add 5 series to chart.
            Top5Chart.Series = new LiveCharts.SeriesCollection
            {
                    //product 1
                    new LineSeries
                    {
                        Title = ""+p1,
                        Values = new ChartValues<int> {
                            pro1[0],pro1[1],pro1[2],pro1[3],pro1[4],pro1[5],pro1[6],pro1[7],pro1[8],pro1[9],pro1[10],pro1[11]
                        }

                    },
                    //product 2
                    new LineSeries
                    {
                        Title = ""+p2,
                        Values = new ChartValues<int> {
                            pro2[0],pro2[1],pro2[2],pro2[3],pro2[4],pro2[5],pro2[6],pro2[7],pro2[8],pro2[9],pro2[10],pro2[11]
                        }
                    },
                    //product 3
                    new LineSeries
                    {
                        Title = ""+p3,
                        Values = new ChartValues<int> {
                            pro3[0],pro3[1],pro3[2],pro3[3],pro3[4],pro3[5],pro3[6],pro3[7],pro3[8],pro3[9],pro3[10],pro3[11]
                        }
                    },
                    //product 4
                    new LineSeries
                    {
                        Title = ""+p4,
                        Values = new ChartValues<int> {
                            pro4[0],pro4[1],pro4[2],pro4[3],pro4[4],pro4[5],pro4[6],pro4[7],pro4[8],pro4[9],pro4[10],pro4[11]
                        }
                    },
                    //product 5
                    new LineSeries
                    {
                        Title = ""+p5,
                        Values = new ChartValues<int> {
                            pro5[0],pro5[1],pro5[2],pro5[3],pro5[4],pro5[5],pro5[6],pro5[7],pro5[8],pro5[9],pro5[10],pro5[11]
                        }
                    },
                };
            //set the X axis.
            Top5Chart.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            //set the Y axis.
            Top5Chart.AxisY.Add(new Axis
            {
                Title = "Quantity",
                LabelFormatter = value => value.ToString("C")
            });

            Top5Chart.LegendLocation = LegendLocation.Right;

            //TOP 5 products DONE.

        }
    }
}
