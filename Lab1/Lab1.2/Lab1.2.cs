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
			Console.Write("�������, ������� ������ ������ � ������ �����: ");
			uint sec = UInt32.Parse(Console.ReadLine());

			while (sec > 36000)
            {
				Console.WriteLine("������������ ������! ��������� ����!");
				Console.Write("�������, ������� ������ ������ � ������ �����: ");
				sec = UInt32.Parse(Console.ReadLine());
			}

			uint hours = sec / 3600;
			sec %= 3600;
			uint min = sec / 60;
			sec %= 60;

			Console.WriteLine($"� ������ ����� ������ {hours} �����, {min} ����� � {sec} ������");
		}
	}
}