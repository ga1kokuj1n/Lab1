using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите первый катет: ");
			double k1 = Double.Parse(Console.ReadLine());
			bool got;
			do
			{
				if (k1 <= 0)
				{
					Console.WriteLine("Некорректные данные! Повторите ввод!");
					k1 = Double.Parse(Console.ReadLine());
					got = true;
				}
				else
					got = false;
			} while (got);
			Console.Write("Введите второй катет: ");
			double k2 = Double.Parse(Console.ReadLine());
			do
			{
				if (k2 <= 0)
				{
					Console.WriteLine("Некорректныые данные! Повтроите ввод");
					k2 = Double.Parse(Console.ReadLine());
					got = true;
				}
				else
					got = false;
			} while (got);

			double hyp = Math.Sqrt(k1 * k1 + k2 * k2);
			double P = k1 + k2 + hyp;
			double S = k1 * k2 / 2;
			Console.WriteLine($"Периметр треугольника: {P}\nПлощадь треугольника: {S}");
		}
	}
}
