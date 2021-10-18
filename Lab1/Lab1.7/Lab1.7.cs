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
            bool got;
            do
            {
                if (num < 100 || num > 999)
                {
                    Console.WriteLine("Некорректные данные! Повторите ввод!");
                    num = Int32.Parse(Console.ReadLine());
                    got = true;
                }
                else
                    got = false;
            } while (got);

            int reversed = (num / 100) + (num / 10 % 10 * 10) + (num % 10 * 100);
            Console.WriteLine(reversed);
        }
    }
}
