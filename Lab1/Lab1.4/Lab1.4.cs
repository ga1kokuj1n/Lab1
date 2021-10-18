using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа:");
            int num1, num2;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            num1 += num2;
            num2 = num1 - num2;
            num1 -= num2;
            Console.WriteLine($"Число 1: {num1}\nЧисло 2: {num2}");
        }
    }
}
