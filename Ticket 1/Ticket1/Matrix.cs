using System;

namespace Ticket1
{
    public class Matrix
    {
        //количество строк

        public int n;

        //количество столбцов

        public int m;
        public int[,] matr;
        public int max;
        public int min;

        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;

            matr = new int[n, m];
        }

        public void find()
        {
            max = matr[0, 0];
            min = matr[0, 0];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matr[i, j] < min)
                        min = matr[i, j];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matr[i, j] > max)
                        max = matr[i, j];
                }
            }
        }
    }
}