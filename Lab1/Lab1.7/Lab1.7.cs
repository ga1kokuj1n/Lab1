using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            while (num < 100 || num > 999)
            {
                Console.WriteLine("Некорректные данные! Повторите ввод!");
                num = Int32.Parse(Console.ReadLine());
            }

            int reversed = (num / 100) + (num / 10 % 10 * 10) + (num % 10 * 100);
            Console.WriteLine(reversed);
        }
    }
}