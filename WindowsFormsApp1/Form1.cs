using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h = double.Parse(textBox1.Text);
            double w = double.Parse(textBox2.Text);
            double BMI = w / (h * h);
            string status = "";
            label1.Text = $"{BMI:F2}\n";
            if (BMI > 25)
            {
                status = "overweight";
            }
            else if (BMI < 18.5) 
            {
                status = "underweight";            
            }
            else
            {
                status = "optimal weight";
            }
            label1.Text += $"Status:{status}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
