using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите, сколько часов показывают часы: ");
			int h = Int32.Parse(Console.ReadLine());
			Console.Write("А минут?:");
			int m = Int32.Parse(Console.ReadLine());
			Console.Write("А секунд?:");
			int s = Int32.Parse(Console.ReadLine());
			while (h < 0 || h > 11 || m < 0 || m > 59 || s < 0 || s > 59)
            {
				Console.WriteLine("Некорректные данные! Повторите ввод!");
				Console.Write("Введите, сколько часов показывают часы: ");
				h = Int32.Parse(Console.ReadLine());
				Console.Write("А минут?:");
				m = Int32.Parse(Console.ReadLine());
				Console.Write("А секунд?:");
				s = Int32.Parse(Console.ReadLine());
			}

			double ans = 30 * h + 0.5 * m + 0.008333 * s;
			Console.WriteLine($"Ответ: {ans}");
		}
	}
}