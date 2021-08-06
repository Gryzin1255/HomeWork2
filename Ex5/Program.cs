using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b)");
            Console.WriteLine("Введите число A");
            int A = Getint();
            Console.WriteLine("Введите чисто B");
            int B = Getint();
            Console.WriteLine("Сумма чисел = " + SumAB(A, B));
            Console.ReadKey();
        }
        static int Getint()
        {
            int.TryParse(Console.ReadLine(), out int x);

            return x;
        }
        static int SumAB(int a, int b)
        {
            if (a == b) return a;
            else return SumAB(a, b - 1) + b;
        }
    }
}
