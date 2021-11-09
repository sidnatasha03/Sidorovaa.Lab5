using System;

namespace Sidorova.Lab5.Exercise2
{
    class Program
    {
        static double Method(double x, double k)
        {

            double a = 5 * k / Math.Pow(k, 2) + Math.PI * Math.Sqrt(x);
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            Console.WriteLine();
            double x = Convert.ToDouble(Console.ReadLine());
            double b = 0.0;
            Console.WriteLine();
            Console.WriteLine("Сумма:"); Console.WriteLine();
            for (int k = 1; k <= 7; k++)
            {
                double f = Method(x, k);

                b += f;
                Console.WriteLine(String.Format("{0:0.0000}   ", b));
            }

            Console.WriteLine();
            Console.WriteLine("Итог: " + b);

            Console.WriteLine();

            Console.WriteLine("Произведение: ");
            Console.WriteLine();
            for (int k = 1; k <= 7; k++)
            {
                double f = Method(x, k);

                b *= f;

                Console.WriteLine(String.Format("{0:0.0000}   ", b));
            }

            Console.WriteLine();
            Console.WriteLine("Итог: " + b);
            Console.WriteLine();

        }
    }
}
