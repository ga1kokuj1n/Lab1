using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Indiv1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("x = ");
			double x = float.Parse(Console.ReadLine());
			Console.Write("a = ");
			double a = float.Parse(Console.ReadLine());
			Console.Write("b = ");
			double b = float.Parse(Console.ReadLine());
			Console.Write("c = ");
			double c = float.Parse(Console.ReadLine());
			double f, z;

			if (b != 0 && a + x*x > 0)
            {
                Console.Write("f = ");
				f = Math.Log(a + x * x) + Math.Sin(x / b) * Math.Sin(x / b);
                Console.WriteLine(f);
			}else
                Console.WriteLine("f: Введённые значения не соответствуют области определения функции");

			if (x + a >= 0 && x != Math.Sqrt(Math.Abs(x - b)))
            {
                Console.Write("z = ");
				z = Math.Pow(Math.E, -c * x) * (x + Math.Sqrt(x + a)) / (x - Math.Sqrt(Math.Abs(x - b)));
                Console.WriteLine(z);
			}else
                Console.WriteLine("z: Введённые значения не соответствуют области определения функции");
		}
	}
}
