using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ticket1
{
    public partial class Form1 : Form
    {
        private int n = 4;
        private int m = 5;

        List<List<int>> list = new List<List<int>>();
        List<List<TextBox>> matrixList = new List<List<TextBox>>();

        public Form1()
        {
            InitializeComponent();

            CreateTextBoxes();
        }


        private void DeleteControls()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    this.Controls.Remove(matrixList[i][j]);
                }
            }

            Controls.Remove(textLabel);
            Controls.Remove(textLabel2);
        }

        private void ClearLists()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    list.Clear();
                    matrixList.Clear();
                }
            }
        }

        private void CreateTextBoxes()
        {
            for (int i = 0; i < n; i++)
            {
                matrixList.Add(new List<TextBox>());

                for (int j = 0; j < m; j++)
                {
                    matrixList.Add(new List<TextBox>());
                    TextBox tempTextBox = new TextBox()
                    {
                        Name = Convert.ToString(i) + Convert.ToString(j),
                        Location = new Point(20 + 35 * j, 20 + 35 * i),
                        Size = new System.Drawing.Size(30, 30),
                        Text = "0"
                    };
                    matrixList[i].Add(tempTextBox);
                    Controls.Add(matrixList[i][j]);
                }

                list.Add(new List<int>());
            }
        }

        private void PrintLabel(Matrix a)
        {
            textLabel = new Label();
            textLabel.AutoSize = true;
            textLabel.BackColor = Color.Transparent;
            textLabel.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            textLabel.ForeColor = Color.Gray;
            textLabel.Location = new Point(55 + 35 * n, 20);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(200, 30);
            textLabel.Text = $"Умножение = {a.min * a.max}";
            this.Controls.Add(textLabel);

            textLabel2 = new Label();
            textLabel2.AutoSize = true;
            textLabel2.BackColor = Color.Transparent;
            textLabel2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            textLabel2.ForeColor = Color.Gray;
            textLabel2.Location = new Point(55 + 35 * n, 55);
            textLabel2.Name = "textLabel";
            textLabel2.Size = new Size(200, 30);
            textLabel2.Text = $"Сумма = {a.min + a.max}";
            this.Controls.Add(textLabel2);
        }

        private void EnableTexbox()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrixList[i][j].Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matrix a = new Matrix(n, m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int number;

                    if (Int32.TryParse(matrixList[i][j].Text, out number))
                        a.matr[i, j] = number;
                    else
                    {
                        MessageBox.Show("Ошибка");
                        return;
                    }
                    a.matr[i, j] = number;
                }
            }

            a.find();
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