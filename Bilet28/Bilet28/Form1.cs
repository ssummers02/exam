using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilet28
{
    public partial class Form1 : Form
    {
        double intNumerator;
        double intDenominator;
        double imgNum;
        double imgDen;
        public Form1()
        {
            InitializeComponent();
        }
        public void Solve()
        {
            int numbers;
            int j;

            switch (comboBox1.SelectedItem)
            {
                case "-":
                    textBox6.Visible = false;
                    textBox8.Visible = false;
                    numbers = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox3.Text);
                    j = Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox4.Text);
                    textBox5.Text = numbers.ToString();
                    textBox7.Visible = true;
                    textBox7.Text = j.ToString();
                    break;
                default:
                    intNumerator = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox4.Text);
                    intDenominator = Math.Pow(Convert.ToDouble(textBox3.Text), 2) + Math.Pow(Convert.ToDouble(textBox4.Text), 2);
                    imgNum = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox4.Text);
                    imgDen = Math.Pow(Convert.ToDouble(textBox3.Text), 2) + Math.Pow(Convert.ToDouble(textBox4.Text), 2);
                    Cancellation();
                    textBox5.Text = intNumerator.ToString();
                    textBox6.Visible = true;
                    textBox6.Text = intDenominator.ToString();
                    textBox7.Visible = true;
                    textBox7.Text = imgNum.ToString();
                    textBox8.Visible = true;
                    textBox8.Text = imgDen.ToString();
                    label2.Visible = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Solve();
        }
        void Cancellation()
        {
            if (intNumerator != 0)
            {
                double m = intDenominator,
                    n = intNumerator,
                    ost = m % n;

                while (ost != 0)
                {
                    m = n;
                    n = ost;
                    ost = m % n;
                }

                double nod = n;

                if (nod != 1)
                {
                    intNumerator /= nod;
                    intDenominator /= nod;
                }
            }
            if (imgNum != 0)
            {
                double m = imgDen,
                    n = imgNum,
                    ost = m % n;

                while (ost != 0)
                {
                    m = n;
                    n = ost;
                    ost = m % n;
                }

                double nod = n;

                if (nod != 1)
                {
                    imgNum /= nod;
                    imgDen /= nod;
                }
            }
        }

    }
}
