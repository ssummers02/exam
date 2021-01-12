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
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            for(int i=0; i< 3; i++)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matrixA[i, j] = Convert.ToInt32(dataGridView1[i, j]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("sdsds");
            }
        }

    }
}
