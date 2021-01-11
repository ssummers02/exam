using System;
using System.Windows.Forms;
using System.Linq;

namespace kek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string kek()
        {
            TextBox[,] ar_box1 = new[,]
            {
                {textBox1, textBox2}, 
                {textBox3, textBox4},
            };
            
            TextBox[,] ar_box2 = new[,]
            {
                {textBox5, textBox6}, 
                {textBox7, textBox8},
            };
            string str =
                $"{Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox7.Text)} {Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox8.Text)} \n{Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox7.Text)} {Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox8.Text)}";
            return str;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = kek();
        }
    }
    
}