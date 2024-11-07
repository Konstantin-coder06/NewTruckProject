using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            richTextBox1.ReadOnly = true;
            InitializeComponent();
        }
        ControllerDrivers controllerDrivers;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = controllerDrivers.Drivers();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            controllerDrivers = new ControllerDrivers();
        }
    }
}
