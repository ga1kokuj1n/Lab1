using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1
{
    class Lab1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double x = Double.Parse(Console.ReadLine());
            int d = (int)((x - (int)x)*10);
            Console.WriteLine($"Результат: {d}");
        }
    }
}
