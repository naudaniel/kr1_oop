using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x2
{
    class Program
    {
        static void Main()
        {
            int[,] array = Matrix.CreateMatrix();     // Ініціалізація масиву

            Console.WriteLine("\nGiven array:");
            Matrix.Print(array);                      // Висновок створеного масиву на консоль

            Matrix.ProductMax(array);                 // Висновок максимального елемента масиву
            Matrix.ProductMin(array);                 // Висновок мінімального елемента масиву

            Matrix.Change(array);                     // Зміна місць рядків з максимальним і мінімальним елементами масиву

            Console.WriteLine("\nModified array:");
            Matrix.Print(array);                      // Висновок зміненого масиву на консоль

            Console.ReadKey();
        }
    }
}
