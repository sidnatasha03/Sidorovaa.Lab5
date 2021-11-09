using System;

namespace Sidorova.Lab5.Exercise1
{
    class Program
    {
        static double Function(double x, double k)
        {

            double f = (5 * k) / (Math.Pow(k, 2) + Math.PI * Math.Sqrt(x));
            return f;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите цикл: for,while, do-while");
            string line = Console.ReadLine();
            switch (line)
            {
                case "for":
                    Console.WriteLine();
                    for (double xq = 0.0; xq <= 1.0; xq += 0.1)
                    {


                        for (double kq = 1.0; kq <= 10.0; kq++)
                        {


                            Console.Write(String.Format("{0:0.0000}  ", Function(xq, kq)));

                        }
                        Console.WriteLine();
                    }

                    break;

                case "while":
                    Console.WriteLine();
                    double xw = 0.0;


                    while (xw <= 1.0)
                    {


                        double kw = 1.0;
                        while (kw <= 10.0)
                        {
                            Console.Write(String.Format("{0:0.0000}   ", Function(xw, kw)));
                            kw++;

                        }
                        xw += 0.1;
                        Console.WriteLine();

                    }

                    break;

                case "do-while":
                    Console.WriteLine();
                    double xe = 0.0;


                    do
                    {

                        double ke = 1.0;

                        do
                        {

                            Console.Write(String.Format("{0:0.0000}   ", Function(xe, ke)));
                            ke++;

                        }
                        while (ke <= 10.0);
                        Console.WriteLine();
                        xe += 0.1;
                    }
                    while (xe <= 1.0);
                    break;
            }




        }
    }
}