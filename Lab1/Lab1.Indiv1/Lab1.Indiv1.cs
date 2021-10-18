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
            public string Name;
            public Emp emp;
            public int birthYear;
            public int payAmount;
        }

        static void Main(string[] args)
        {
            Console.Write("Сколько записей вы внесёте?: ");

        }
    }
}
