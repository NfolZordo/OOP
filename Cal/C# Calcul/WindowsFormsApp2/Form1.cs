using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();


        }
        double a, f1;
        int sign, duit;
        string naf = "";
        void result()
        {
            if (duit == 1)
            {
                f1 = f1 * a;
            }
            if (duit == 2)
            {
                f1 = f1 / a;
            }
            if (duit == 3)
            {
                f1 = f1 + a;
            }
            if (duit == 4)
            {
                f1 = f1 - a;
            }
            
        }
        private void button3_Click(object sender, EventArgs  e)
        {
            if (sign != 1)
            {
                f1 = double.Parse(textBox1.Text);
                textBox1.Text = naf.ToString();
                textBox3.Text = f1.ToString();
                sign = 1;
            }
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = naf.ToString();
                result();
                textBox3.Text = f1.ToString();
            }
            duit = 1;
            textBox1.Focus();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            result();
            textBox3.Text = f1.ToString();
            textBox1.Text = naf.ToString();
            duit = 0;
            textBox1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sign != 1)
            {
                f1 = double.Parse(textBox1.Text);
                textBox1.Text = naf.ToString();
                textBox3.Text = f1.ToString();
                sign = 1;
            }
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = naf.ToString();
                result();
                textBox3.Text = f1.ToString();
            }
            duit = 2;
            textBox1.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            f1 = 0;
            sign = 0;
            a = 0;
            textBox1.Text = naf.ToString(); 
            textBox3.Text = naf.ToString();
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sign != 1)
            {
                f1 = double.Parse(textBox1.Text);
                textBox1.Text = naf.ToString();
                textBox3.Text = f1.ToString();
                sign = 1;
            }
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = naf.ToString();
                result();
                textBox3.Text = f1.ToString();
            }
            duit = 4;
            textBox1.Focus();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sign != 1)
            {
                f1 = double.Parse(textBox1.Text);
                textBox1.Text = naf.ToString();
                textBox3.Text = f1.ToString();
                sign = 1;
            }
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = naf.ToString();
                result();
                textBox3.Text = f1.ToString();
            }
            duit = 3;
            textBox1.Focus();

        }
    }
}
