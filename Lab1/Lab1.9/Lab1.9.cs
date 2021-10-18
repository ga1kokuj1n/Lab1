using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a1: ");
            double a1 = Double.Parse(Console.ReadLine());
            Console.Write("b1: ");
            double b1 = Double.Parse(Console.ReadLine());
            Console.Write("c1: ");
            double c1 = Double.Parse(Console.ReadLine());
            Console.Write("d1: ");
            double d1 = Double.Parse(Console.ReadLine());
            Console.Write("a2: ");
            double a2 = Double.Parse(Console.ReadLine());
            Console.Write("b2: ");
            double b2 = Double.Parse(Console.ReadLine());
            Console.Write("c2: ");
            double c2 = Double.Parse(Console.ReadLine());
            Console.Write("d2: ");
            double d2 = Double.Parse(Console.ReadLine());
            Console.Write("a3: ");
            double a3 = Double.Parse(Console.ReadLine());
            Console.Write("b3: ");
            double b3 = Double.Parse(Console.ReadLine());
            Console.Write("c3: ");
            double c3 = Double.Parse(Console.ReadLine());
            Console.Write("d3: ");
            double d3 = Double.Parse(Console.ReadLine());

            double def = (a1 * b2 * c3) + (b1 * c2 * a3) + (c1 * a2 * b3) - (a3 * b2 * c1) - (b3 * c2 * a1) - (c3 * a2 * b1);
            if (def == 0)
            {
                Console.WriteLine("Ошибка: определитель равен 0!");
                return;
            }

            double defx = (d1 * b2 * c3) + (b1 * c2 * d3) + (c1 * d2 * b3) - (d3 * b2 * c1) - (b3 * c2 * d1) - (c3 * d2 * b1);
            double defy = (a1 * d2 * c3) + (d1 * c2 * a3) + (c1 * a2 * d3) - (a3 * d2 * c1) - (d3 * c2 * a1) - (c3 * a2 * d1);
            double defz = (a1 * b2 * d3) + (b1 * d2 * a3) + (d1 * a2 * b3) - (a3 * b2 * d1) - (b3 * d2 * a1) - (d3 * a2 * b1);

            Console.WriteLine($"x: {defx/def}\ny: {defy/def}\nz: {defz/def}");
        }
    }
}
