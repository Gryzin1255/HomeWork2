using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчета ИМТ");
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
    }
}
