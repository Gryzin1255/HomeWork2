using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//static void Main(string[] args)

namespace HomeWork2
{
    class Program
    {
        static int minOfThree(int a, int b, int c)
        {

            if (a > b) a = b;
            if (a > c) a = c;
            return a;

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
        static string BMi(double bmi, double heigth)
        {
            string result = "";
            if (bmi >= 18.5 && bmi <= 24.99)
            {
                result = "Всё в норме!";
            }
            else if (bmi < 18.5)
            {
                double recommendation = (18.5 - bmi) * heigth * heigth;
                result = String.Format("Необходимо набрать {0:0.00} кг для нормализации веса!", recommendation);
            }
            else if (bmi > 24.99)
            {
                double recommendation = (bmi - 24.99) * heigth * heigth;
                result = String.Format("Необходимо сбросить {0:0.00} кг для нормализации веса!", recommendation);
            }

            return result;
        }
        static void Task1()
        {
            Console.Write("a = ");
            int a = Getint();
            Console.Write("b = ");
            int b = Getint();
            Console.Write("c = ");
            int c = Getint();

            Console.WriteLine("Min=" + minOfThree(a, b, c));
            Console.ReadKey();
        }
        static void Task2()
        {
            Console.Write("a = ");
            int a = Getint();
            Console.WriteLine("Количество цифр = " + DigitCount(a));
            Console.ReadLine();

        }
        static void Task3()
        {
            Console.WriteLine("Вводите числа по одному, дял завершения введите 0: ");
            int a = 0;
            while (true)
            {
                int number = Getint();
                if (number == 0)
                {
                    break;
                }
                else if (number > 0 && number % 2 == 1) ;
                {
                    a++;
                }
            }

            Console.WriteLine("Количество чисел: " + a);
            Console.ReadLine();
        }
        static void Task4()
        {
        }


        static void Task5()
        {
            Console.WriteLine("Введи вес в кг: ");
            double mass = double.Parse(Console.ReadLine());

            Console.Write("Введите рост человека в см: ");
            double heigth = double.Parse(Console.ReadLine());

            heigth /= 100;

            Console.Write(Environment.NewLine + "Индекс массы тела: ");
            double bmi = mass / (heigth * heigth);
            Console.WriteLine("{0:0.##}", bmi);

            Console.WriteLine(BMi(bmi, heigth));


            Console.ReadKey();
        }
        static void Task6()
        {

        }
        static void Task7()
        {

            Console.WriteLine("Введите число A");
            int A = Getint();
            Console.WriteLine("Введите чисто B");
            int B = Getint();
            Console.WriteLine("Сумма чисел = " + SumAB(A, B));
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Костев Николай!");
            Console.WriteLine("Введите номер задачи,кроме 4 и 6:");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("  Написать метод, возвращающий минимальное из трёх чисел");
                    Task1();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("  Написать метод подсчета количества цифр числа");
                    Task2();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("  С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел");
                    Task3();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Task4();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Console.WriteLine(" Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает," +
                        " нужно ли человеку похудеть, набрать вес или всё в норме.");
                    Task5();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Task6();
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    Console.WriteLine("  Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).");
                    Task7();
                    break;
            }


        }
    }
}