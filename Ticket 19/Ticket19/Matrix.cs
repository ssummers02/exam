using System;

namespace Ticket19
{
    public class QuadraticEquation
    {
        double a, b, c;
        double sqrtpart;
        public string x1, x2;

        public QuadraticEquation(double a, double c)
        {
            this.a = a;
            this.b = 0;
            this.c = c;
            Diskriminant();
        }

        private void Diskriminant()
        {
            sqrtpart = b * b - 4 * a * c;
        }

        public void Solve()
        {
            double t;

            if (sqrtpart > 0)
            {
                t = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                x1 = t.ToString("F3");
                t = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = t.ToString("F3");
            }
            else if (sqrtpart == 0)
            {
                t = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine(t);
                x1 = t.ToString("F3");
                Console.WriteLine(x1);

                x2 = "отсутсвует";
            }
            else
            {
                t = -System.Math.Sqrt(Math.Abs(-c / a));
                x1 = t.ToString("F3") + 'i';
                t = System.Math.Sqrt(Math.Abs(-c / a));
                x2 = t.ToString("F3") + 'i';
            }
        }
    }
}