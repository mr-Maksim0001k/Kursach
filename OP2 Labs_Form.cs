using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP1___CSharp_WinForm___Labs
{
    public partial class OP1_Labs_Form : Form
    {
        public OP1_Labs_Form()
        {
            InitializeComponent();
            panelActiveButton.Height = BTN_Start.Height*10;
            panelActiveButton.Top = BTN_Start.Top;
            lab0_UC1.BringToFront();
            label2.Text = "КР - Об’єктно-орієнтовне програмування С#";
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            panelActiveButton.Height = BTN_Start.Height;
            panelActiveButton.Top = BTN_Start.Top;
            label2.Text = "Курсова робота";
            lab10_UC1.BringToFront();
        }

        private void lab10_UC1_Load(object sender, EventArgs e)
        {

        }
    }
}
