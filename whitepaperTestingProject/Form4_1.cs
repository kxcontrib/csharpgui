using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using kx;

namespace whitepaperTestingProject
{
    public partial class Form4_1 : Form
    {
        c conn;
        double min, max, dAvg, dVwap;
        long transNo;

        public Form4_1(String symbol, c conn)
        {
            InitializeComponent();

            symLabel.Text = symbol;
            this.conn = conn;
            c.Flip details = GetData("select details from details where sym=`" + symbol);
            compLabel.Text = c.at(details.y[0], 0).ToString();
            details = GetData("getSummary[`" + symbol + "]");
            GetDaily(details);
            
            details = GetData("analyseData[`" + symbol + "]");
            SetAxis(details);
            PopulateChart(details);
            PopulateGrid(details);
        }

        private void SetAxis(c.Flip details)
        {
            double min = 1000;
            double max = 0;

            for (int i = 0; i < details.getNoRow(); i++)
            {
                for (int j = 3; j < (details.getNoColumns())-1; j++)
                {
                    double minVal = (double)c.at(details.y[j], i);
                    double maxVal = (double)c.at(details.y[j], i);

                    if (minVal < min)
                    {
                        min = minVal;
                    }
                    if (maxVal > max)
                    {
                        max = maxVal;
                    }
                }
                
            }
            reportChart.ChartAreas[0].AxisY.Minimum = min - 0.0025;
            reportChart.ChartAreas[0].AxisY.Maximum = max + 0.0025;
            reportChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
        }

        private void GetDaily(c.Flip details)
        {
            min = (double)c.at(details.y[1], 0);
            max = (double)c.at(details.y[2], 0);
            dAvg = (double)c.at(details.y[3], 0);
            dVwap = (double)c.at(details.y[4], 0);
            transNo = (long)c.at(details.y[5], 0);

            minBox.Text = min.ToString("#.#####");
            maxBox.Text = max.ToString("#.#####");
            avgBox.Text = dAvg.ToString("#.#####");
            dailyVwap.Text = dVwap.ToString("#.#####");
            transNoBox.Text = transNo.ToString();
        }

        private c.Flip GetData(String query)
        {
            object result = (object)conn.k(query);
            c.Flip table = (c.Flip)result;
            return table;
        }

        private void PopulateChart(c.Flip details)
        {
            for (int i = 0; i < details.getNoRow(); i++)
            {
                reportChart.Series["vwap"].Points.AddXY((c.at(details.y[0], i)).ToString(), (double)c.at(details.y[3], i));
                reportChart.Series["avg"].Points.AddXY((c.at(details.y[0], i)).ToString(), (double)c.at(details.y[4], i));
                reportChart.Series["dailyAvg"].Points.AddXY((c.at(details.y[0], i)).ToString(), dAvg);
                reportChart.Series["dailyVwap"].Points.AddXY((c.at(details.y[0], i)).ToString(), dVwap);
            }
        }

        private void PopulateGrid(c.Flip table) {
            resultsGridView.Columns.Clear();
                foreach (string colName in table.getColumns())
                {
                    resultsGridView.Columns.Add(colName, colName);
                }

                resultsGridView.Rows.Add(table.getNoRow());

                for (int row = 0; row < table.getNoRow(); row++)
                {
                    for (int col = 0; col < (table.getColumns().Length); col++)
                    {
                        resultsGridView[col, row].Value = c.at(table.y[col], row);
                    }
                }
        }

        private void ChangeView_Click(object sender, EventArgs e)
        {
            if (resultsGridView.Visible == false)
            {
                reportChart.Visible = false;
                resultsGridView.Visible = true;
                ChangeView.Text = "Change to Graph";
            }
            else
            {
                resultsGridView.Visible = false;
                reportChart.Visible = true;
                ChangeView.Text = "Change to Grid";
            }
        }


    }
}
