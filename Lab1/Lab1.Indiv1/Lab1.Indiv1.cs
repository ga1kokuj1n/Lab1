using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Indiv1
{
	class Program
	{
		public enum Position { Student, Educator, Aspirent }
		public class Unit
		{
			public string name { get; private set; }
			public Position pos { get; private set; }
			public int birthYear { get; private set; }
			public float salary { get; private set; }
			public string posView { get; private set; }
			public Unit(string n, string p, int b, float s)
            {
				name = n;
				birthYear = b;
				salary = s;
				posView = p;
				switch(p)
                {
					case "C": pos = Position.Student; break;
					case "П": pos = Position.Educator; break;
					case "А": pos = Position.Aspirent; break;
                }
            }
		}
		static void Main(string[] args)
		{
            Console.Write("Сколько записей вы желаете внести: ");
			int unitsAmount = int.Parse(Console.ReadLine());

			Unit[] units = new Unit[unitsAmount];
			for (int i = 0; i < unitsAmount; i++)
            {
				Console.Write($"[{i + 1}]Имя: ");
				string n = Console.ReadLine();

				Console.Write($"[{i + 1}]Должность: ");
				string pv = Console.ReadLine();
				while (pv != "С" && pv != "П" && pv != "А")
                {
                    Console.WriteLine("Некореектные данные! Повторите ввод");
					Console.Write($"[{i + 1}]Должность: ");
					pv = Console.ReadLine();
				}

				Console.Write($"[{i + 1}]Год рождения: ");
				int y = int.Parse(Console.ReadLine());
				while (y < 1900 || y > DateTime.Today.Year)
                {
					Console.WriteLine("Некореектные данные! Повторите ввод");
					Console.Write($"[{i + 1}]Год рождения: ");
					y = int.Parse(Console.ReadLine());
				}

				Console.Write($"[{i + 1}]Оклад (грн): ");
				float s = float.Parse(Console.ReadLine());
				while(s < 0)
                {
					Console.WriteLine("Некореектные данные! Повторите ввод");
					Console.Write($"[{i + 1}]Оклад (грн): ");
					s = float.Parse(Console.ReadLine());
				}

				units[i] = new Unit(n, pv, y, s);
			}

			Console.Clear();
            Console.WriteLine("Отдел кадров");
            Console.WriteLine($"{"Фамилия", -20}|Должность|Год рожд|{"Оклад (грн)"}");
			for (int i = 0; i < unitsAmount; i++)
            {
                Console.WriteLine($"{units[i].name, -20}|{units[i].posView, -9}|{units[i].birthYear, -8}|{units[i].salary:n2}");
            }
            Console.WriteLine("Перечисляемый тип: П - преподаватель, С - студент, А - аспирант");
			Console.ReadKey();
		}
	}
}
