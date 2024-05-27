using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACT_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domainUpDown1.SelectedIndex = 0;
            domainUpDown2.SelectedIndex = 0;
            domainUpDown3.SelectedIndex = 0;
            domainUpDown4.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
                   Convert.ToInt32(numericUpDown1.Value),
                   Convert.ToInt32(numericUpDown2.Value),
                   Convert.ToInt32(numericUpDown3.Value));
            Fraction d2 = new Fraction(1,
                   Convert.ToInt32(numericUpDown4.Value),
                   Convert.ToInt32(numericUpDown5.Value),
                   Convert.ToInt32(numericUpDown6.Value));
            Fraction d3 =d1.Addition(d2);
            numericUpDown7.Value = d3.integer;
            numericUpDown8.Value = d3.numerator;
            numericUpDown9.Value = d3.denominator;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
                  Convert.ToInt32(numericUpDown7.Value),
                  Convert.ToInt32(numericUpDown8.Value),
                  Convert.ToInt32(numericUpDown9.Value));
            Fraction d2 = d1.Correct_Fraction();
            numericUpDown7.Value = d2.integer;
            numericUpDown8.Value = d2.numerator;
            numericUpDown9.Value = d2.denominator;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
                 Convert.ToInt32(numericUpDown7.Value),
                 Convert.ToInt32(numericUpDown8.Value),
                 Convert.ToInt32(numericUpDown9.Value));
            Fraction d2 = d1.Shorter_Fraction();
            numericUpDown7.Value = d2.integer;
            numericUpDown8.Value = d2.numerator;
            numericUpDown9.Value = d2.denominator;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
                 Convert.ToInt32(numericUpDown1.Value),
                  Convert.ToInt32(numericUpDown2.Value),
                   Convert.ToInt32(numericUpDown3.Value));
            Fraction d2 = new Fraction(1,
                   Convert.ToInt32(numericUpDown4.Value),
                   Convert.ToInt32(numericUpDown5.Value),
                   Convert.ToInt32(numericUpDown6.Value));
            Fraction d3;
           
            if (domainUpDown2.Text == "+")
            {
                d3 = d1 + d2;
                numericUpDown7.Value= d3.integer;
                numericUpDown8.Value= d3.numerator;
                numericUpDown9.Value= d3.denominator;
            }
            else if (domainUpDown2.Text == "-")
            {
                d3 = d1 - d2;
                numericUpDown7.Value = d3.integer;
                numericUpDown8.Value = d3.numerator;
                numericUpDown9.Value= d3.denominator;
            }
            else if(domainUpDown2.Text == "*")
            {
                d3 = d1 * d2;
                numericUpDown7.Value = d3.integer;
                numericUpDown8.Value = d3.numerator;
                numericUpDown9.Value= d3.denominator;
            }
            else if (domainUpDown2.Text == "/")
            {
                d3 = d1 / d2;
                numericUpDown7.Value = d3.integer;
                numericUpDown8.Value = d3.numerator;
                numericUpDown9.Value= d3.denominator;
            }
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
                 Convert.ToInt32(numericUpDown1.Value),
                  Convert.ToInt32(numericUpDown2.Value),
                   Convert.ToInt32(numericUpDown3.Value));
            Fraction d2 = new Fraction(1,
                   Convert.ToInt32(numericUpDown4.Value),
                   Convert.ToInt32(numericUpDown5.Value),
                   Convert.ToInt32(numericUpDown6.Value));
            if (d1 > d2)
            {
                MessageBox.Show("Первое значение больше");
            }
            else
            {
                MessageBox.Show("Второе  значение больше");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
                Convert.ToInt32(numericUpDown1.Value),
                 Convert.ToInt32(numericUpDown2.Value),
                  Convert.ToInt32(numericUpDown3.Value));
            Fraction d2 = new Fraction(1,
                   Convert.ToInt32(numericUpDown4.Value),
                   Convert.ToInt32(numericUpDown5.Value),
                   Convert.ToInt32(numericUpDown6.Value));
            if (d1 < d2)
            {
                MessageBox.Show("Первое значение Меньше");
            }
            else
            {
                MessageBox.Show("Второе  значение Меньше");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
              Convert.ToInt32(numericUpDown1.Value),
               Convert.ToInt32(numericUpDown2.Value),
                Convert.ToInt32(numericUpDown3.Value));
            Fraction d2 = new Fraction(1,
                   Convert.ToInt32(numericUpDown4.Value),
                   Convert.ToInt32(numericUpDown5.Value),
                   Convert.ToInt32(numericUpDown6.Value));
            if (d1 <= d2)
            {
                MessageBox.Show("Первое значение Меньше или равно");
            }
            else
            {
                MessageBox.Show("Второе  значение Меньше или равно");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
               Convert.ToInt32(numericUpDown1.Value),
                Convert.ToInt32(numericUpDown2.Value),
                 Convert.ToInt32(numericUpDown3.Value));
            Fraction d2 = new Fraction(1,
                   Convert.ToInt32(numericUpDown4.Value),
                   Convert.ToInt32(numericUpDown5.Value),
                   Convert.ToInt32(numericUpDown6.Value));
            if (d1 >= d2)
            {
                MessageBox.Show("Первое значение Больше или равно");
            }
            else
            {
                MessageBox.Show("Второе  значение Больше или равно");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
              Convert.ToInt32(numericUpDown1.Value),
               Convert.ToInt32(numericUpDown2.Value),
                Convert.ToInt32(numericUpDown3.Value));
            Fraction d2 = new Fraction(1,
                   Convert.ToInt32(numericUpDown4.Value),
                   Convert.ToInt32(numericUpDown5.Value),
                   Convert.ToInt32(numericUpDown6.Value));
            if (d1 != d2)
            {
                MessageBox.Show("Не равные");
            }
            else
            {
                MessageBox.Show("Равные");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
              Convert.ToInt32(numericUpDown1.Value),
               Convert.ToInt32(numericUpDown2.Value),
                Convert.ToInt32(numericUpDown3.Value));
            label1.Text = d1.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string str=textBox1.Text;
            Fraction fraction=Fraction.Parse(str);
            numericUpDown10.Value = fraction.integer;
            numericUpDown11.Value = fraction.numerator;
            numericUpDown12.Value = fraction.denominator;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Fraction d2=Fraction.Parse(textBox2.Text);
            Fraction d3 = Fraction.Parse(textBox3.Text);
            Fraction d4=d2+d3;
            textBox4.Text = d4.ToString();
        }
    }
    
}
