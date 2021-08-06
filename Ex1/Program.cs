using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Нахождение минимального из трех чисел");
            Console.Write("a = ");
            int a = Getint();
            Console.Write("b = ");
            int b = Getint();
            Console.Write("c = ");
            int c = Getint();

            Console.WriteLine("Min=" + minOfThree(a, b, c));
            Console.ReadKey();
        }
        static int minOfThree(int a, int b, int c)
        {

            if (a > b) a = b;
            if (a > c) a = c;
            return a;

        }
        static int Getint()
        {
            int.TryParse(Console.ReadLine(), out int x);

            return x;
        }
    }
}
