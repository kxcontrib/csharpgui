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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                c conn = ConnectionPool.GetConnection(); //This pulls an object of type c from the shared connection pool.
                if (conn != null)
                {
                    textBox1.Text = "You have connected to localhost:5010 successfully";
                }
                else
                {
                    textBox1.Text = "Error, you have not successfully connected to the server";
                }
                ConnectionPool.ReturnConnection(conn);
            }
            catch (Exception ex)
            {
                textBox1.Text = "An expected error occurred: " + ex.Message;
            }
        }
    }
}
