using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnreleaseAmbersand1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void CloseApp()
        {
            Application.Exit();
        }

        private void timer_Time_Tick(object sender, EventArgs e)
        {
            lb_datetime.Text = DateTime.Now.ToLongTimeString();
            lb_Date.Text = DateTime.Now.ToString("ddd") + DateTime.Now.ToString("dd MMM yyyy");
        }
        private void Terminate_Click_1(object sender, EventArgs e)
        {
            CloseApp();
        }

        private void tab_jogging_Click(object sender, EventArgs e)
        {
            usrc_jogging1.Visible = true;
            usrc_programming1.Visible = false;
        }

        private void tab_programming_Click(object sender, EventArgs e)
        {
            usrc_jogging1.Visible = false;
            usrc_programming1.Visible = true;
        }
    }
}
