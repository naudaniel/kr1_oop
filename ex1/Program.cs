using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9, m = 4, sum1 = 0, sum2 = 0;
            int[,] k = new int[n, m];
            Random r = new Random();        //заповнюємо матрицю випадковими числами
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    k[i, j] = r.Next(0, 9);    //кожен елемент приймає значення від 0 до 9
                    Console.Write("{0} ", k[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum1 += k[i, j];       //знаходимо суму всіх елементів рядка
                }
                Console.WriteLine();
                Console.WriteLine("Amount " + (i + 1) + " strings equals " + sum1);     //виводимо суму рядка
                sum1 = 0;    //Обнуляємо отриману суму
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum2 += k[j, i];       //знаходимо суму всіх елементів стовпця
                }
                Console.WriteLine();
                Console.WriteLine("Amount " + (i + 1) + " column is equal to " + sum2);     //виводимо суму рядка
                sum2 = 0;    //Обнуляємо отриману суму
            }
            Console.ReadKey();
        }
    }
}
