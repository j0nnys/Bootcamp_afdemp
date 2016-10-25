using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_4
{
    class Program
    {
        public class Students : IComparable<Students>
        {
            public string Name;
            public double Mark;

            public Students(string name, double mark)
            {
                Name = name;
                Mark = mark;
            }

            public int CompareTo(Students s)
            {
                if (this.Mark < s.Mark)
                {
                    return -1;
                }
                else if (this.Mark > s.Mark)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

       
        static void Main(string[] args)
        {
            List <Students> list = new List <Students>
            {
                    new Students("John", 5),
                    new Students("Mark", 6),
                    new Students("Maria", 3),
                    new Students("Kostas", 5.8),
                    new Students("Petros", 5.7)
            };
            foreach (Students s in list)
            {
                Console.WriteLine(s.Name + " got " + s.Mark);
            }
            Console.WriteLine();
            list.Sort();
            foreach (Students s in list)
            {
                Console.WriteLine(s.Name + " got " + s.Mark);
            }
            Console.ReadKey();
        }
    }
}
