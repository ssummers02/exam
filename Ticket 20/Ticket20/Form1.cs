using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ticket20
{
    public partial class Form1 : Form
    {
        private int n = 6;
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
            pictureBox1 = new PictureBox();
            pictureBox1.Image = Properties.Resources.img;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Location = new Point(20, 20);
            this.Controls.Add(pictureBox1);

            
            textLabel4 = new Label();
            textLabel4.AutoSize = true;
            textLabel4.BackColor = Color.Transparent;
            textLabel4.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            textLabel4.ForeColor = Color.Black;
            textLabel4.Location = new Point(20, 55+35);
            textLabel4.Name = "textLabel4";
            textLabel4.Size = new Size(200, 30);
            textLabel4.Text = $"𝑎 =";
            this.Controls.Add(textLabel4);
            
            textLabel5 = new Label();
            textLabel5.AutoSize = true;
            textLabel5.BackColor = Color.Transparent;
            textLabel5.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            textLabel5.ForeColor = Color.Black;
            textLabel5.Location = new Point(20, 55 + 35*2);
            textLabel5.Name = "textLabel5";
            textLabel5.Size = new Size(200, 30);
            textLabel5.Text = $"𝑏 =";
            this.Controls.Add(textLabel5);
            
            textLabel6= new Label();
            textLabel6.AutoSize = true;
            textLabel6.BackColor = Color.Transparent;
            textLabel6.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            textLabel6.ForeColor = Color.Black;
            textLabel6.Location = new Point(20, 55 + 35*3);
            textLabel6.Name = "textLabel6";
            textLabel6.Size = new Size(200, 30);
            textLabel6.Text = $"c =";
            this.Controls.Add(textLabel6);
            
            textLabel7 = new Label();
            textLabel7.AutoSize = true;
            textLabel7.BackColor = Color.Transparent;
            textLabel7.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            textLabel7.ForeColor = Color.Black;
            textLabel7.Location = new Point(20, 55 + 35*4);
            textLabel7.Name = "textLabel7";
            textLabel7.Size = new Size(200, 30);
            textLabel7.Text = $"d =";
            this.Controls.Add(textLabel7);
            
            textLabel8 = new Label();
            textLabel8.AutoSize = true;
            textLabel8.BackColor = Color.Transparent;
            textLabel8.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            textLabel8.ForeColor = Color.Black;
            textLabel8.Location = new Point(20, 55 + 35*5);
            textLabel8.Name = "textLabel8";
            textLabel8.Size = new Size(200, 30);
            textLabel8.Text = $"f =";
            this.Controls.Add(textLabel8);
            
            textLabel9 = new Label();
            textLabel9.AutoSize = true;
            textLabel9.BackColor = Color.Transparent;
            textLabel9.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            textLabel9.ForeColor = Color.Black;
            textLabel9.Location = new Point(20, 55 + 35*6);
            textLabel9.Name = "textLabel9";
            textLabel9.Size = new Size(200, 30);
            textLabel9.Text = $"k =";
            this.Controls.Add(textLabel9);
            
            
            for (int j = 0; j < n; j++)
            {
                TextBox tempTextBox = new TextBox()
                {
                    Name = Convert.ToString(j),
                    Location = new Point(22 + 35, 55+35 + 35 * j),
                    Size = new System.Drawing.Size(30, 30),
                    Text = "0"
                };
                matrixList.Add(tempTextBox);
                Controls.Add(matrixList[j]);
            }
        }

        private void PrintLabel()
        {

            textLabel = new Label();
            textLabel.AutoSize = true;
            textLabel.BackColor = Color.Transparent;
            textLabel.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            textLabel.ForeColor = Color.Gray;
            textLabel.Location = new Point(200, 20);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(200, 30);
            double a = (Math.Log(Convert.ToDouble(matrixList[1].Text), Convert.ToDouble(matrixList[0].Text)) +
                        Math.Log(Convert.ToDouble(matrixList[3].Text), Convert.ToDouble(matrixList[2].Text))) /
                       Math.Log(Convert.ToDouble(matrixList[5].Text), Convert.ToDouble(matrixList[4].Text));
            textLabel.Text = $"X = {a:f2}";
            this.Controls.Add(textLabel);
            
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
            PrintLabel();
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