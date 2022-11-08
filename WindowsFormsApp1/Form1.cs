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

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double x1, x2, d = b * b - 4 * a * c;
            string s;
            if (d > 0)
            {
                x1 = (-b - Math.Sqrt(d)) / 2 * a;
                x2 = (-b + Math.Sqrt(d)) / 2 * a;
                s = "x1 = " + x1.ToString() + "\nx2 = " + x2.ToString();
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                s = "x1 = " + x1.ToString();
            }
            else
            {
                s = "Корней нет!";
            }
            label5.Text = s;
        }
    }
}
