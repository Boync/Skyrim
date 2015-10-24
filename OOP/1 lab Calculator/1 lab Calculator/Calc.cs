using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_lab_Calculator
{
    public partial class Calc : Form
    {

        public static byte znak = 0;
        public static int one, two;

        public Calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            display.Clear();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            
            znak = 1;
            display.Text += "+";
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            znak = 2;
            display.Text += "-";
        }

        private void button_multi_Click(object sender, EventArgs e)
        {
            znak = 3;
            display.Text += "*";
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            znak = 4;
            display.Text += "/";
        }

        private void button_is_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < display.TextLength; i++)
            {



            }

        }


    }
}
