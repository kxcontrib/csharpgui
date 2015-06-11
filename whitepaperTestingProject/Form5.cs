using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using kx;

namespace whitepaperTestingProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        c conn;

        private c.Flip GetData(String query)
        {
                object result = (object)conn.k(query);
                c.Flip table = (c.Flip)result;
                return table;
        }

        private void PublishQuery(c.Flip table)
        {
            QueryView.Columns.Clear();
            foreach (string colName in table.getColumns())
            {
                QueryView.Columns.Add(colName, colName);
            }

            QueryView.Rows.Add(table.getNoRow());

            for (int row = 0; row < table.getNoRow(); row++)
            {
                for (int col = 0; col < (table.getColumns().Length); col++)
                {
                    QueryView[col, row].Value = c.at(table.y[col], row);
                }
            }
        }

        private void runComButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn = ConnectionPool.GetConnection();
                String query = queryBox.Text;
                c.Flip table = GetData(query);
                PublishQuery(table);
            }
            catch (Exception ex)
            {
                if (ex.Message == "read" || ex.Message == "stop")
                {
                    try
                    {
                        if (ex.Message == "read")
                        {
                            errorLabel.Text = "ALERT: using secondary connection";
                        }
                        else
                        {
                            errorLabel.Text = "ALERT: query timed out, using second connection";
                        }
                        
                        conn = ConnectionPool.GetConnection();
                        c.Flip table = GetData(queryBox.Text);
                        PublishQuery(table);
                    }
                    catch (Exception ee)
                    {
                        errorLabel.Text = "ERROR - unable to connect: " + ee.Message;
                    }
                }
                else
                {
                    errorLabel.Text = "ERROR: " + ex.Message;
                }
            }
            ConnectionPool.ReturnConnection(conn);
        }
    }
}
