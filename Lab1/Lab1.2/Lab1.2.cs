using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите, сколько прошло секунд с начала суток: ");
			uint sec = UInt32.Parse(Console.ReadLine());

			while (sec >= 86400)
			{
				Console.WriteLine("Некорректные данные! Повторите ввод!");
				Console.Write("Введите, сколько прошло секунд с начала суток: ");
				sec = UInt32.Parse(Console.ReadLine());
			}

			uint hours = sec / 3600;
			sec %= 3600;
			uint min = sec / 60;
			sec %= 60;

			Console.WriteLine($"С начала суток прошло {hours} часов, {min} минут и {sec} секунд");
		}
	}
}