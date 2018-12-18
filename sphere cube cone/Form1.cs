using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sphere_cube_cone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(textBox1.Text);
                double ans1 = 4.0 / 3.0 * Math.PI * r * r * r;
                label1.Text = "Volue = " + ans1.ToString("0.00");

            }
            catch
            {
                MessageBox.Show("Enter a nuber");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double 1 = double.Parse(textBox2.Text);
                double ans2 = 1 * 1 * 1;
                label4.Text = "Volume = " + ans2.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double i = double.Parse(textBox3.Text);
                double h = double.Parse(textBox3.Text);
                double ans3 = 1.0 / 3.0 * Math.PI * r1 * r1 * h / 3.0;
                label6.Text = "Volume = " + ans3.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
        }
    }
}

