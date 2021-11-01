using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using computers;

namespace T0413
{
    public partial class Form0413 : Form
    {
        public Form0413()
        {
            InitializeComponent();
        }

        private void buttonCreateFirst_Click(object sender, EventArgs e)
        {
            string name = textBoxNameFirst.Text;
            int count = Convert.ToInt32(numericUpDownCountFirst.Value);
            int distance = Convert.ToInt32(numericUpDownDistanceFirst.Value);
            ComputerWebFirstLevel computersWeb = new ComputerWebFirstLevel(name, count, distance);

            labelInfoFirst.Text = String.Format("Params:\n{0}", computersWeb.getParams());
        }

        private void buttonCreateSecond_Click(object sender, EventArgs e)
        {
            string name = textBoxNameSecond.Text;
            int count = Convert.ToInt32(numericUpDownCountSecond.Value);
            int distance = Convert.ToInt32(numericUpDownDistanceSecond.Value);
            int speed = Convert.ToInt32(numericUpDownSpeedSecond.Value);
            ComputerWebSecondLevel computersWeb = new ComputerWebSecondLevel(name, count, distance, speed);

            labelInfoSecond.Text = String.Format("Params:\n{0}", computersWeb.getParams());
        }
    }
}
