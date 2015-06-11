using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using kx;

/*
 Before running this, run the following in the kdb+ sesson to clear the password authentication
 * q) \x .z.pw
*/
namespace whitepaperTestingProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        c conn;

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                try
                {
                    conn = ConnectionPool.GetConnection();
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }
            object result = (object)conn.k("select from trade");
            c.Flip table = (c.Flip)result;

            QueryView.Columns.Clear();//Clear columns first to allow clean population of table
            foreach (string colName in table.getColumns())
            {
                QueryView.Columns.Add(colName, colName); //Add the columns to the Queryview
            }

            QueryView.Rows.Add(table.getNoRow());

            for (int row = 0; row < table.getNoRow(); row++)
            {
                for (int col = 0; col < (table.getColumns().Length); col++)
                {
                    QueryView[col, row].Value = c.at(table.y[col], row); //Populate each cell of the Queryview with its associated value
                }
            }
            ConnectionPool.ReturnConnection(conn);
        }
    }
}
