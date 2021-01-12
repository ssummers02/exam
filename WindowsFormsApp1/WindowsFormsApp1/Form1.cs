using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int[,] matrixA = new int[3,3];
        int[,] matrixB = new int[3, 3];
        int[,] result = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            dataGridView2.RowCount = 3;
            dataGridView2.ColumnCount = 3;
            dataGridView3.RowCount = 3;
            dataGridView3.ColumnCount = 3;
            for (int i=0; i< 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1[i, j] = new DataGridViewTextBoxCell();
                }
            }
            foreach(DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = 25;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataGridView2[i, j] = new DataGridViewTextBoxCell();
                }
            }
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.Width = 25;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataGridView3[i, j] = new DataGridViewTextBoxCell();
                }
            }
            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                column.Width = 25;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matrixA[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
                        matrixB[i, j] = Convert.ToInt32(dataGridView2[i, j].Value);
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        result[i, j] = 0;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            result[i, j] += Convert.ToInt32(dataGridView1[i, k].Value) * Convert.ToInt32(dataGridView2[k, j].Value);
                            dataGridView3[i, j].Value = result[i, j];
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                
            }
        }
    }

}
