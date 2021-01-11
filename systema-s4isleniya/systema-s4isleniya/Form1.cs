using System;
using System.Windows.Forms;

namespace systema_s4isleniya {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private string DecimalToBinary(int dec) {
            string bin = "";
            while (dec > 0) {
                bin += $"{dec % 2}";
                dec /= 2;
            }
            char[] charArray = bin.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private int BinaryToDecimal(string bin) {
            char[] charArray = bin.ToCharArray();
            Array.Reverse(charArray);
            int dec = 0;
            for (int i = 0; i < charArray.Length; i++) {
                dec += (int) Math.Pow(2, i) * Convert.ToInt32(charArray[i].ToString());
            }
            return dec;
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                int d1 = Convert.ToInt32(textBox1.Text);
                int d2 = Convert.ToInt32(textBox2.Text);
                int res;
                string sign = "*";
                if (comboBox1.Text == "+") {
                    res = d1 + d2;
                    sign = "+";
                }
                    else res = d1 * d2;
                textBox3.Text = $"{res}";
                label1.Text = $"{DecimalToBinary(d1)} {sign} {DecimalToBinary(d2)} = {DecimalToBinary(res)}";
            }
            catch {
                MessageBox.Show("Некорректно введены данные");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            button1.Enabled = true;
        }
    }
}
