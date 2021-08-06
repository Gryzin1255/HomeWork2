using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для подсчета количества цифр в нем");
            int a = Getint();
            Console.WriteLine("Количество цифр = " + DigitCount(a));
            Console.ReadLine();
        }
        static int Getint()
        {
            int.TryParse(Console.ReadLine(), out int x);

            return x;
        }
        static int DigitCount(int n)
        {
            int count = 0;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }
            return count;
        }

    }
}
