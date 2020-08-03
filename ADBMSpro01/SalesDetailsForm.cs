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

        //connection.
        DBconnection dbcon = new DBconnection();

        public static SqlConnection myCon = null;
        SqlDataReader DR;

        String p1 = "Empty", p2 = "Empty", p3 = "Empty", p4 = "Empty", p5 = "Empty";

        int[] pro1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] pro2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] pro3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] pro4 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] pro5 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        int[] qtySpro = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        float[] totSpro = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //set data to product search charts.

            SearchProductQtyChart.Series.Clear();
            SearchProductTotChart.Series.Clear();

            string Pname = ProductSearchTxt.Text;
            int year = 0;


            if (ProductYearCBox.SelectedItem != null)
            {
                year = int.Parse(ProductYearCBox.SelectedItem.ToString());
            }
            else
            {
                //Value is null 
            }

            string QTYsql = "SELECT SUM(Quantity) as qty, " +
                "MONTH(Sdate) as month " +
                "FROM Sales " +
                "WHERE YEAR(Sdate)  = " + year + " and Pname = '" + Pname + "' " +
                "group by MONTH(Sdate)" +
                "order by MONTH(Sdate)";

            string TOTsql = "SELECT SUM(Total) as total, " +
                "MONTH(Sdate) as month " +
                "FROM Sales " +
                "WHERE YEAR(Sdate)  = " + year + " and Pname = '" + Pname + "' " +
                "group by MONTH(Sdate)" +
                "order by MONTH(Sdate)";

            //set Data QTY chart
            myCon = dbcon.setCon();

            using (myCon)
            {
                //read sql.
                SqlCommand cmd = new SqlCommand(QTYsql, myCon);

                DR = cmd.ExecuteReader();
                using (DR)
                {
                    while (DR.Read())
                    {
                        int value = (int)DR.GetInt32(0);
                        qtySpro[i] = value;
                        i++;
                    }
                }
                i = 0;
                DR = null;
            }

            //add series to chart.
            SearchProductQtyChart.Series = new LiveCharts.SeriesCollection
            {
                    new LineSeries
                    {
                        Title = ""+Pname,
                        Values = new ChartValues<int> {
                            qtySpro[0], qtySpro[1], qtySpro[2], qtySpro[3], qtySpro[4], qtySpro[5], qtySpro[6], qtySpro[7], qtySpro[8], qtySpro[9], qtySpro[10], qtySpro[11]
                        }
                    },
            };

            //clear values.
            while (i <= 11)
            {
                qtySpro[i] = 0;
                i++;
            }
            i = 0;


            //SearchProductQtyChart.Update();

            //set Data TOTAL chart
            myCon = dbcon.setCon();

            using (myCon)
            {
                //read sql.
                SqlCommand cmd = new SqlCommand(TOTsql, myCon);

                DR = cmd.ExecuteReader();
                using (DR)
                {
                    while (DR.Read())
                    {
                        float value = (float)DR.GetDouble(0);
                        totSpro[i] = value;
                        i++;
                    }
                }
                i = 0;
                DR = null;
            }

            //add series to chart.
            SearchProductTotChart.Series = new LiveCharts.SeriesCollection
            {
                    new LineSeries
                    {
                        Title = ""+Pname,
                        Values = new ChartValues<float> {
                            totSpro[0], totSpro[1], totSpro[2], totSpro[3], totSpro[4], totSpro[5], totSpro[6], totSpro[7], totSpro[8], totSpro[9], totSpro[10], totSpro[11]
                        }
                    },
            };

            //clear values.
            while (i <= 11)
            {
                totSpro[i] = 0;
                i++;
            }
            i = 0;
        }

        int i = 0;

        

        public SalesDetailsForm()
        {
            InitializeComponent();
        }

        private void SalesDetailsForm_Load(object sender, EventArgs e)
        {
            //Top 5 products monthly sales.

            //set product 1.
            myCon = dbcon.setCon();
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

            //clear values.
            while (i <= 11)
            {
                pro1[i] = 0;
                pro2[i] = 0;
                pro3[i] = 0;
                pro4[i] = 0;
                pro5[i] = 0;
                i++;
            }
            i = 0;

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
                LabelFormatter = value => value.ToString()
            });

            Top5Chart.LegendLocation = LegendLocation.Right;

            //Top 5 products chart DONE.

            //Load QTY and TOTAL charts.

            //QTY chart.
            //set the X axis.
            SearchProductQtyChart.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            //set the Y axis.
            SearchProductQtyChart.AxisY.Add(new Axis
            {
                Title = "Quantity",
                LabelFormatter = value => value.ToString()
            });

            SearchProductQtyChart.LegendLocation = LegendLocation.Right;


            //Show TOTAL chart
            //set the X axis.
            SearchProductTotChart.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            //set the Y axis.
            SearchProductTotChart.AxisY.Add(new Axis
            {
                Title = "Total",
                LabelFormatter = value => value.ToString("C")
            });

            SearchProductTotChart.LegendLocation = LegendLocation.Right;

        }
    }
}
