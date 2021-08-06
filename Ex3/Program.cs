using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчета положительных нечетных чисел\nВводите числа по одному, дял завершения введите 0: ");
            
                int sum = 0;
                int num = 0;

            do
                {
                num = Getint();
                if (num > 0 && num % 2 == 1)
                    sum += num;

            } while (num != 0) ;

            Console.WriteLine("Сумма нечетных чисел = " + sum);
            Console.ReadKey();
        }
        static int Getint()
        {
            int.TryParse(Console.ReadLine(), out int x);

            return x;
        }
    }
}
