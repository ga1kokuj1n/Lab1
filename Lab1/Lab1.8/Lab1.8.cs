using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите х: ");
            double x = double.Parse(Console.ReadLine());

            double ans = x * (x * (x * (3 * x - 5) + 2) - 1) + 7;
            Console.WriteLine($"Ответ: {ans}");
        }
    }
}
