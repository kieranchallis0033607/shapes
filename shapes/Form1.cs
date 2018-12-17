using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double calc = double.Parse(textBox1.Text);
                double answer = 4.0 / 3.0 * Math.PI * calc * calc * calc;
                label7.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("enter a number");
            }
           


        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                double calc2 = double.Parse(textBox2.Text);
                double answer2 = calc2 * calc2 * calc2;
                label11.Text = answer2.ToString();
            }
            catch
            {
                MessageBox.Show("enter a number");
            }
        }
    }
}
