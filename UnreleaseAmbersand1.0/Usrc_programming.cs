using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnreleaseAmbersand1._0
{
    public partial class Usrc_programming : UserControl
    {
        public Usrc_programming()
        {
            InitializeComponent();
        }

        private void btn_ptp_Click(object sender, EventArgs e)
        {
            txt_commandName.Text = "Move point-to-point";
            tab_Param.SelectedIndex = 0;
        }

        private void btn_linear_Click(object sender, EventArgs e)
        {
            txt_commandName.Text = "Move Linear";
            tab_Param.SelectedIndex = 1;
        }

        private void btn_cir_Click(object sender, EventArgs e)
        {
            txt_commandName.Text = "Move Circular";
            tab_Param.SelectedIndex = 2;
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {

        }

        private void btn_setVel_Click(object sender, EventArgs e)
        {
            txt_commandName.Text = "Set velocity";
            tab_Param.SelectedIndex = 3;
        }

        private void btn_w8input_Click(object sender, EventArgs e)
        {
            txt_commandName.Text = "Wait Input";
            tab_Param.SelectedIndex = 6;
        }

        private void btn_w8time_Click(object sender, EventArgs e)
        {
            txt_commandName.Text = "Wait time";
            tab_Param.SelectedIndex = 7;
        }

        private void btn_setoutput_Click(object sender, EventArgs e)
        {
            txt_commandName.Text = "Set Output";
            tab_Param.SelectedIndex = 8;
        }

        private void btn_transmode_Click(object sender, EventArgs e)
        {
            //txt_commandName.Text = "Transition Mode";
            //tab_Param.SelectedIndex = 9;
        }
    }
}
