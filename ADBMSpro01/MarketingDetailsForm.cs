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

        int i = 0;

        String p1 = "Empty", p2 = "Empty", p3 = "Empty", p4 = "Empty", p5 = "Empty";

        float[] SearchcostValue = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        float[] costpro1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        float[] costpro2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        float[] costpro3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        float[] costpro4 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        float[] costpro5 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        //connection.
        DBconnection dbcon = new DBconnection();

        public MarketingDetailsForm()
        {
            InitializeComponent();
        }

        private void MarketingDetailsForm_Load(object sender, EventArgs e)
        {
            //Top 5 products monthly sales.

            //set product 1.
            myCon = dbcon.setCon();
            using (myCon)
            {
                //read store procedure.
                SqlCommand cmd = new SqlCommand("GetCostProduct1", myCon);

                cmd.CommandType = CommandType.StoredProcedure;

                DR = cmd.ExecuteReader();
                i = 0;
                using (DR)
                {
                    while (DR.Read())
                    {
                        p1 = (String)DR.GetString(0);
                        float value = (float)DR.GetDouble(1);
                        costpro1[i] = value;
                        i++;
                    }
                }
                DR.Close();
            }

            //set product 2.
            myCon = dbcon.setCon();
            using (myCon)
            {
                //read store procedure.
                SqlCommand cmd = new SqlCommand("GetCostProduct2", myCon);

                cmd.CommandType = CommandType.StoredProcedure;

                DR = cmd.ExecuteReader();
                i = 0;
                using (DR)
                {
                    while (DR.Read())
                    {
                        p2 = (String)DR.GetString(0);
                        float value = (float)DR.GetDouble(1);
                        costpro2[i] = value;
                        i++;
                    }
                }
                DR.Close();
            }
            //set product 3.
            myCon = dbcon.setCon();
            using (myCon)
            {
                //read store procedure.
                SqlCommand cmd = new SqlCommand("GetCostProduct3", myCon);

                cmd.CommandType = CommandType.StoredProcedure;

                DR = cmd.ExecuteReader();
                i = 0;
                using (DR)
                {
                    while (DR.Read())
                    {
                        p3 = (String)DR.GetString(0);
                        float value = (float)DR.GetDouble(1);
                        costpro3[i] = value;
                        i++;
                    }
                }
                DR.Close();
            }
            //set product 4.
            myCon = dbcon.setCon();
            using (myCon)
            {
                //read store procedure.
                SqlCommand cmd = new SqlCommand("GetCostProduct4", myCon);

                cmd.CommandType = CommandType.StoredProcedure;

                DR = cmd.ExecuteReader();
                i = 0;
                using (DR)
                {
                    while (DR.Read())
                    {
                        p4 = (String)DR.GetString(0);
                        float value = (float)DR.GetDouble(1);
                        costpro4[i] = value;
                        i++;
                    }
                }
                DR.Close();
            }
            //set product 5.
            myCon = dbcon.setCon();
            using (myCon)
            {
                //read store procedure.
                SqlCommand cmd = new SqlCommand("GetCostProduct5", myCon);

                cmd.CommandType = CommandType.StoredProcedure;

                DR = cmd.ExecuteReader();
                i = 0;
                using (DR)
                {
                    while (DR.Read())
                    {
                        p5 = (String)DR.GetString(0);
                        float value = (float)DR.GetDouble(1);
                        costpro5[i] = value;
                        i++;
                    }
                }
                DR.Close();
            }

            //add 5 series to chart.
            Product5Chart.Series = new LiveCharts.SeriesCollection
            {
                    //product 1
                    new LineSeries
                    {
                        Title = ""+p1,
                        Values = new ChartValues<float> {
                            costpro1[0],costpro1[1],costpro1[2],costpro1[3],costpro1[4],costpro1[5],costpro1[6],costpro1[7],costpro1[8],costpro1[9],costpro1[10],costpro1[11]
                        }

                    },
                    //product 2
                    new LineSeries
                    {
                        Title = ""+p2,
                        Values = new ChartValues<float> {
                            costpro2[0],costpro2[1],costpro2[2],costpro2[3],costpro2[4],costpro2[5],costpro2[6],costpro2[7],costpro2[8],costpro2[9],costpro2[10],costpro2[11]
                        }
                    },
                    //product 3
                    new LineSeries
                    {
                        Title = ""+p3,
                        Values = new ChartValues<float> {
                            costpro3[0],costpro3[1],costpro3[2],costpro3[3],costpro3[4],costpro3[5],costpro3[6],costpro3[7],costpro3[8],costpro3[9],costpro3[10],costpro3[11]
                        }
                    },
                    //product 4
                    new LineSeries
                    {
                        Title = ""+p4,
                        Values = new ChartValues<float> {
                            costpro4[0],costpro4[1],costpro4[2],costpro4[3],costpro4[4],costpro4[5],costpro4[6],costpro4[7],costpro4[8],costpro4[9],costpro4[10],costpro4[11]
                        }
                    },
                    //product 5
                    new LineSeries
                    {
                        Title = ""+p5,
                        Values = new ChartValues<float> {
                            costpro5[0],costpro5[1],costpro5[2],costpro5[3],costpro5[4],costpro5[5],costpro5[6],costpro5[7],costpro5[8],costpro5[9],costpro5[10],costpro5[11]
                        }
                    },
            };

            //clear values.
            i = 0;
            while (i <= 11)
            {
                costpro1[i] = 0;
                costpro2[i] = 0;
                costpro3[i] = 0;
                costpro4[i] = 0;
                costpro5[i] = 0;
                i++;
            }
            i = 0;

            //set the X axis.
            Product5Chart.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            //set the Y axis.
            Product5Chart.AxisY.Add(new Axis
            {
                Title = "Quantity",
                LabelFormatter = value => value.ToString()
            });

            Product5Chart.LegendLocation = LegendLocation.Right;

            //5 products cost chart DONE.



            //set searching chart.
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            myCon = dbcon.setCon();

            string name = ProductNameTxt.Text;
            int year = 0;


            if (ProductYearCBox.SelectedItem != null)
            {
                year = int.Parse(ProductYearCBox.SelectedItem.ToString());
            }
            else
            {
                //Value is null 
            }

            string sql = "select SUM(Mcost) as total, " +
                "MONTH(Mdate) as month " +
                "from Marketing " +
                "where YEAR(Mdate) = "+year+" and Mdescription = '"+name+"' " +
                "group by MONTH(Mdate) " +
                "order by MONTH(Mdate)";

            //set cost.
            myCon = dbcon.setCon();

            using (myCon)
            {
                //read store procedure.
                SqlCommand cmd1 = new SqlCommand(sql, myCon);

                DR = cmd1.ExecuteReader();
                i = 0;
                using (DR)
                {
                    while (DR.Read())
                    {
                        float value = (float)DR.GetDouble(0);
                        SearchcostValue[i] = value;
                        i++;
                    }
                }
                DR.Close();
            }

            //add series to chart.
            MarketingMonthChart.Series = new LiveCharts.SeriesCollection
            {
                    new LineSeries
                    {
                        Title = ""+name,
                        Values = new ChartValues<double> {
                            SearchcostValue[0], SearchcostValue[1], SearchcostValue[2], SearchcostValue[3], SearchcostValue[4], SearchcostValue[5], SearchcostValue[6], SearchcostValue[7], SearchcostValue[8], SearchcostValue[9], SearchcostValue[10], SearchcostValue[11]
                        }
                    },
            };

            //clear values.
            i = 0;
            while (i <= 11)
            {
                SearchcostValue[i] = 0;
                i++;
            }
            i = 0;
        }
    }
}
