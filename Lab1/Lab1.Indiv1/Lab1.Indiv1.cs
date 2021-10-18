using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Indiv1
{
	class Program
	{
		public enum Emp { Educator, Student, Aspirent }
		public class Employee
		{
			public string name;
			public Emp emp;
			public int birthYear;
			public float payAmount;
			public Employee(string n, Emp e, int b, float p)
			{
				name = n;
				emp = e;
				birthYear = b;
				payAmount = p;
			}
			public string PrintIt(int nw, int pw)
			{
				string p = ((int)payAmount).ToString() + '.' + ((int)((payAmount - (int)payAmount) * 2)).ToString();
				if ((int)(payAmount - (int)payAmount) < 10)
					p += '0';
				string em = "";
				switch (emp)
				{
					case Emp.Aspirent: em = "А            |"; break;
					case Emp.Educator: em = "П            |"; break;
					case Emp.Student: em = "С            |"; break;
				}
				return '|' + name + new string(' ', nw - name.Length) + '|' + em + birthYear.ToString() + "     |" + p + new String(' ', pw - p.ToString().Length) + '|';
			}
		}

		static void Main(string[] args)
		{
			Console.Write("Сколько записей вы внесёте?: ");
			int accCount = int.Parse(Console.ReadLine());

			Employee[] employees = new Employee[accCount];

			int nw = 20, pw = 20;
			for (int i = 0; i < accCount; i++)
			{
				Console.Write($"[{i + 1}]Имя: ");
				string n = Console.ReadLine();
				if (n.Length + 5 > nw)
					nw = n.Length + 5;

				Console.Write($"[{i + 1}]Должность: ");
				string em = Console.ReadLine();
				Emp e;
			sw: switch (em)
				{
					case "П":
						e = Emp.Educator;
						break;
					case "С":
						e = Emp.Student;
						break;
					case "А":
						e = Emp.Aspirent;
						break;
					default:
						Console.WriteLine("Некорректные данные! Повторите ввод!");
						Console.Write($"[{i + 1}]Должность: ");
						em = Console.ReadLine();
						goto sw;
				}

				Console.Write($"[{i + 1}]Год рождения: ");
				int a = int.Parse(Console.ReadLine());
				bool got;
				do
				{
					if (a < 1900 || a > 2006)
					{
						Console.WriteLine("Некорректные данные! Повторите ввод!");
						Console.Write($"[{i + 1}]Год рождения: ");
						a = int.Parse(Console.ReadLine());
						got = false;
					}
					else
						got = true;
				} while (!got);

				Console.Write($"[{i + 1}]Оклад (грн): ");
				float p = float.Parse(Console.ReadLine());
				do
				{
					if (p < 0)
					{
						Console.WriteLine("Некорректные данные! Повторите ввод!");
						Console.Write($"[{i + 1}]Оклад (грн): ");
						p = float.Parse(Console.ReadLine());
						got = false;
					}
					else
						got = true;
				} while (!got);
				string p1 = ((int)p).ToString() + ((int)((p - (int)p) * 2)).ToString();
				if (p1.Length + 5 > pw)
					pw = p.ToString().Length + 5;

				employees[i] = new Employee(n, e, a, p);
			}

			Console.Clear();
			string separator = '+' + new String('-', nw) + "+-------------+---------+" + new String('-', pw) + '+';
			string separator2 = '+' + new String('-', nw) + "-------------------------" + new String('-', pw) + '+';
			Console.WriteLine(separator2);
			Console.WriteLine("|Отдел кадров" + new String(' ', nw + pw + 13) + "|");
			Console.WriteLine(separator);
			Console.WriteLine("|Фамилия" + new String(' ', nw - 7) + "|Должность    |Год рожд |Оклад (грн)" + new String(' ', pw - 11) + '|');
			Console.WriteLine(separator);
			foreach (Employee i in employees)
			{
				Console.WriteLine(i.PrintIt(nw, pw));
				Console.WriteLine(separator);
			}
			Console.WriteLine("|Перечисляемый тип: П - преподаватель, С - студент, А - аспирант" + new String(' ', nw + pw - 38) + '|');
			Console.WriteLine(separator2);
			Console.ReadKey();
		}
	}
}
