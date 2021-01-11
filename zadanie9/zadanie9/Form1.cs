using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie9
{
    public partial class Form1 : Form
    {
        int[,] origMatrix = new int[2, 2];
        int[,] minorMatrix = new int[2, 2];
        int[] freeMemMatrix = new int[2];
        double[,] inverseMatrix = new double[2, 2];
        double[] resultMatrix = new double[2];
        int determinant;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 2;
            dataGridView2.RowCount = 2;
            dataGridView2.ColumnCount = 1;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    dataGridView1[i, j] = new DataGridViewTextBoxCell();
                }
            }
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = 40;
            }
            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                col.Width = 40;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // input original matrix
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        origMatrix[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }
                // input free members matrix
                for (int i = 0; i < 2; i++)
                {
                    freeMemMatrix[i] = Convert.ToInt32(dataGridView1.Rows[1].Cells[i].Value);
                }
                
                determinant = origMatrix[0, 0] * origMatrix[1, 1] - origMatrix[0, 1] * origMatrix[1, 0];
                if (Math.Abs(determinant) == 0) throw new Exception("Обратной матрицы не существует!");
                
                minorMatrix = cosntructMinorMatrix(origMatrix);
                
                //double div_det = (-1.0 / determinant);
                //inverseMatrix[0, 0] = minorMatrix[0, 0] * div_det;
                //inverseMatrix[0, 1] = minorMatrix[0, 1] * div_det;
                //inverseMatrix[1, 0] = minorMatrix[1, 0] * div_det;
                //inverseMatrix[1, 1] = minorMatrix[1, 1] * div_det;

                resultMatrix[0] = minorMatrix[0, 0] * freeMemMatrix[0] + minorMatrix[0, 1] * freeMemMatrix[1];
                resultMatrix[1] = minorMatrix[1, 0] * freeMemMatrix[0] + minorMatrix[1, 1] * freeMemMatrix[1];
                for (int j = 0; j < 2; j++)
                {
                    MessageBox.Show(resultMatrix[j].ToString());
                }
                double div_det = (-1.0 / determinant);
                resultMatrix[0] = resultMatrix[0] * div_det;
                resultMatrix[1] = resultMatrix[1] * div_det;

                textBox1.Text = resultMatrix[0].ToString();
                textBox2.Text = resultMatrix[1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int[,] cosntructMinorMatrix(int[,] matrix)
        {
            int[,] resMatrix = new int[2, 2];
            resMatrix[0, 0] = matrix[1,1];
            resMatrix[0, 1] = matrix[0, 1] * -1;
            resMatrix[1, 0] = matrix[1, 0] * -1;
            resMatrix[1, 1] = matrix[0, 0];

            return resMatrix;
        }

        public double calculateDeterminant(int[,] matrix)
        {
            double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            return det;
        }
    }
}
