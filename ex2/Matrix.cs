using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x2
{
    static class Matrix
    {
        static int i, j;                   // Лічильники циклів
        static int lineMax, lineMin;       // Рядки з максимальним і мінімальним елементами масиву

        // Метод для створення масиву
        public static int[,] CreateMatrix()
        {
            int[,] array = new int[9, 4];
            Random r = new Random();

            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(0, 9);    //кожен елемент приймає значення від 0 до 9
                }
            }
            return array;
        }

        // Метод для виведення масиву на екран
        public static void Print(int[,] array)
        {
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }

        // Пошук максимального значення
        public static void ProductMax(int[,] array)
        {
            int max = array[0, 0];
            lineMax = 0;
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        lineMax = i;
                    }
                }
            }
            Console.WriteLine("\nThe largest value is \"{0}\" in \"{1}\" line", max, lineMax + 1);
        }

        // Пошук найменшого значення
        public static void ProductMin(int[,] array)
        {
            int min = array[0, 0];
            lineMin = 0;
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        lineMin = i;
                    }
                }
            }
            Console.WriteLine("The smallest value is \"{0}\" in \"{1}\" line", min, lineMin + 1);
        }

        // Міняємо місцями рядки з найбільшим і найменшим значеннями
        public static void Change(int[,] array)
        {
            for (i = 0; i < array.GetLength(0); i++)
                if (lineMin == lineMax)
                {
                    Console.WriteLine("The maximum and minimum elements are on the same line! " +
                         "\nThe modified array will be the same as the specified one.");
                    break;
                }
                else
                {
                    int tmp = array[lineMin, i];
                    array[lineMin, i] = array[lineMax, i];
                    array[lineMax, i] = tmp;
                }
        }
    }
}
