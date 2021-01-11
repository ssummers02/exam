using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilet_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double sum()
        {
            double res = 0;
            int n = Convert.ToInt32(textBox1.Text);
            while (n < 100)
            {
                res += 1.0 / (n*n);
                n++;
            }
            
            return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\Максим\Desktop\aaaa.PNG");
            label2.Text = $"Ряд сходится так как предел = 0\nСумма ряда при n = {Convert.ToInt32(textBox1.Text)}: {sum()}";
        }
    }
}