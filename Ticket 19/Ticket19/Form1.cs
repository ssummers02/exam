using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ticket19
{
    public partial class Form1 : Form
    {
        private int n = 2;
        List<List<int>> list = new List<List<int>>();
        List<TextBox> matrixList = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();

            CreateTextBoxes();
        }


        private void DeleteControls()
        {
            for (int j = 0; j < n; j++)
            {
                this.Controls.Remove(matrixList[j]);
            }

            Controls.Remove(textLabel);
            Controls.Remove(textLabel2);
        }

        private void ClearLists()
        {
            for (int j = 0; j < n; j++)
            {
                list.Clear();
                matrixList.Clear();
            }
        }

        private void CreateTextBoxes()
        {
            textLabel3 = new Label();
            textLabel3.AutoSize = true;
            textLabel3.BackColor = Color.Transparent;
            textLabel3.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            textLabel3.ForeColor = Color.Black;
            textLabel3.Location = new Point(20, 20);
            textLabel3.Name = "textLabel3";
            textLabel3.Size = new Size(200, 30);
            textLabel3.Text = $"𝑎𝑥^2+𝑏=0";
            this.Controls.Add(textLabel3);

            for (int j = 0; j < n; j++)
            {
                textLabel4 = new Label();
                textLabel4.AutoSize = true;
                textLabel4.BackColor = Color.Transparent;
                textLabel4.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
                textLabel4.ForeColor = Color.Black;
                textLabel4.Location = new Point(20, 55);
                textLabel4.Name = "textLabel4";
                textLabel4.Size = new Size(200, 30);
                textLabel4.Text = $"𝑎 =";
                this.Controls.Add(textLabel4);
                textLabel5 = new Label();
                textLabel5.AutoSize = true;
                textLabel5.BackColor = Color.Transparent;
                textLabel5.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
                textLabel5.ForeColor = Color.Black;
                textLabel5.Location = new Point(20, 55 + 35);
                textLabel5.Name = "textLabel5";
                textLabel5.Size = new Size(200, 30);
                textLabel5.Text = $"𝑏 =";
                this.Controls.Add(textLabel5);
                TextBox tempTextBox = new TextBox()
                {
                    Name = Convert.ToString(j),
                    Location = new Point(20 + 35, 55 + 35 * j),
                    Size = new System.Drawing.Size(30, 30),
                    Text = "0"
                };
                matrixList.Add(tempTextBox);
                Controls.Add(matrixList[j]);
            }
        }

        private void PrintLabel(QuadraticEquation a)
        {
            a.Solve();

            textLabel = new Label();
            textLabel.AutoSize = true;
            textLabel.BackColor = Color.Transparent;
            textLabel.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            textLabel.ForeColor = Color.Gray;
            textLabel.Location = new Point(55 + 70, 20);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(200, 30);
            textLabel.Text = $"X1 = {a.x1}";
            this.Controls.Add(textLabel);

            textLabel2 = new Label();
            textLabel2.AutoSize = true;
            textLabel2.BackColor = Color.Transparent;
            textLabel2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            textLabel2.ForeColor = Color.Gray;
            textLabel2.Location = new Point(55 + 70, 55);
            textLabel2.Name = "textLabel2";
            textLabel2.Size = new Size(200, 30);
            textLabel2.Text = $"X2 = {a.x2}";
            this.Controls.Add(textLabel2);
        }

        private void EnableTexbox()
        {
            for (int j = 0; j < n; j++)
            {
                matrixList[j].Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuadraticEquation a = new QuadraticEquation(Convert.ToDouble(matrixList[0].Text),
                Convert.ToDouble(matrixList[1].Text));
            PrintLabel(a);
            EnableTexbox();
        }

        private void cleanButtonClick(object sender, EventArgs e)
        {
            DeleteControls();
            ClearLists();
            CreateTextBoxes();
        }
    }
}