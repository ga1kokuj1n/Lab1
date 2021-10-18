using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите четырёхзначное число: ");
			int num = Int32.Parse(Console.ReadLine());
			bool got;
			do
			{
				if (num < 1000 || num > 9999)
				{
					Console.WriteLine("Некорректные данные! Повторите ввод");
					num = Int32.Parse(Console.ReadLine());
					got = true;
				}
				else
					got = false;
			} while (got);

			int ans = (num / 1000) * (num / 100 % 10) * (num / 10 % 10) * (num % 10);
			Console.WriteLine($"Ответ: {ans}");
		}
	}
}
