using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using kx; //This must be referenced to call ODBC methods
using System.Timers;

namespace whitepaperTestingProject
{
    public partial class Form4 : Form
    {

        c conn;

        public Form4()
        {
            InitializeComponent();
            try
            {
                conn = ConnectionPool.GetConnection();
                object[] result = (object[])conn.k("tables[]");
                for (int i = 0; i < result.Length; i++)
                {
                    tableComboBox.Items.Add(result[i]);
                }
            }
            catch (Exception ex)
            {
                errorLabel.Text = "Unexpected error: " + ex.Message;
            }
        }

        

        private string BuildQuery()
        {

            String check1 = "";
            String check2 = "";
            String check3 = "";
            StringBuilder queryString = new StringBuilder();

            if (checkBox1.Checked)
            {
                check1 = " not ";
            }
            if (checkBox2.Checked)
            {
                check2 = " not ";
            }
            if (checkBox3.Checked)
            {
                check3 = " not ";
            }

            if ((selectedCols.Text == null) || (selectedCols.Text == "*"))
            {
                queryString.Append("select from ");
            }
            else
            {
                queryString.Append("select " + selectedCols.Text + " from ");
            }

            queryString.Append(tableComboBox.SelectedItem);

            if (argComboBox1.SelectedItem != null)
            {
                queryString.Append(" where (" + check1 + argComboBox1.SelectedItem + signComboBox1.SelectedItem + argInput1.Text + ")"); //Append the above strings and the text boxes of the UI into a single string query that can be sent to the kdb+ process
            }

            if ((argComboBox2.SelectedItem != null) && (argComboBox1.SelectedItem != null))
            {
                queryString.Append(andor1.SelectedItem + " (" + check2 + argComboBox2.SelectedItem + signComboBox2.SelectedItem + argInput2.Text + ")");
            }

            if ((argComboBox2.SelectedItem != null) && (argComboBox1.SelectedItem != null) && (argComboBox3.SelectedItem != null))
            {
                queryString.Append(andor2.SelectedItem + " (" + check3 + argComboBox3.SelectedItem + signComboBox3.SelectedItem + argInput3.Text + ")");
            }

            return queryString.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = ConnectionPool.GetConnection();
                }

                String query = BuildQuery();

                try
                {
                    object result = null;
                    result = (object)conn.k(query);

                    c.Flip table = (c.Flip)result;

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
                    errorLabel.Text = "";
                    QueryView.CellClick += (QueryView_CellClick);
                }
                catch (Exception ex)
                {
                    errorLabel.Text = "ERROR:" + ex.Message;
                }
                ConnectionPool.ReturnConnection(conn);
            }
            catch (Exception ex)
            {
                errorLabel.Text = "Unexpected error: " + ex.Message;
            }
        }

        private void colCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedCols.Text == "")
            {
                selectedCols.Text = colCombo.SelectedItem.ToString();
            }
            else
            {
                selectedCols.Text = selectedCols.Text + "," + colCombo.SelectedItem;
            }
        }

        private void removeCols_Click(object sender, EventArgs e)
        {
            selectedCols.Text = "";
        }

        private void QueryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                DataGridView senderGrid = (DataGridView)sender;
                String selSym = senderGrid.Rows[rowIndex].Cells[1].Value.ToString();
                Form4_1 frm3 = new Form4_1(selSym, conn);
                frm3.ShowDialog(this);
            }
        }

        private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = ConnectionPool.GetConnection();
                }

                argComboBox1.Items.Clear();
                argComboBox3.Items.Clear();
                argComboBox3.Items.Clear();
                object[] cols = (object[])conn.k("exec c from (meta " + tableComboBox.SelectedItem.ToString() + ")");
                for (int i = 0; i < cols.Length; i++)
                {
                    argComboBox1.Items.Add(cols[i]);
                    argComboBox2.Items.Add(cols[i]);
                    argComboBox3.Items.Add(cols[i]);
                }
            }
            catch (Exception ex)
            {
                errorLabel.Text = "Unexpected error: " + ex.Message;
            }
        }
    }
}