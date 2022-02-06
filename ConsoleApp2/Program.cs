using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int a, b, c;
            double FinaleGrade;
            Console.WriteLine("Write your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter 3 grades");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            FinaleGrade = a * 0.20 + b * 0.20 + c * 0.60;
            Console.WriteLine("Finale grade is {0}", FinaleGrade);
            if ((FinaleGrade != a) || (FinaleGrade != b) || (FinaleGrade != c))
                Console.WriteLine("The finale grade is not epule to one of the grades");
            else
                switch (FinaleGrade)
                {
                case double n when (n == a):
                    Console.WriteLine("The finale grade is equle to the first grade: {0}", a);
                    break;

                case double n when (n == b):
                    Console.WriteLine("The finale grade is equle to the second grade: {0}", b);
                    break;

                case double n when (n == c):
                    Console.WriteLine("The finale grade is equle to the third grade: {0}", c);
                    break;
                }
        }
    }
}
