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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                c conn = ConnectionPool.GetConnection(usernameText.Text, pwText.Text);
                label3.Text = "Hello " + usernameText.Text + ". You are permitted to make this connection";
            }
            catch (KException kEx)
            {
                if (kEx.Message == "access") //Permission denied
                {
                    label3.Text = "Sorry " + usernameText.Text + ". You may not make this connection";
                }
                else
                {
                    label3.Text = "An unexpected kdb+ error occurred";
                }
            }
            catch (Exception ex)
            {
                label3.Text = ex.Message;
            }
        }
    }
}
