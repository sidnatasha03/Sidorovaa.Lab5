using System;

namespace Sidorova.Lab5.Exercise3;
class Program
{
    static void Main(string[] args)
    {

        int cruch = 10;
        int ckar = 5;
        int clas = 2;
        int sum = 100;

        int ruch = 0;
        int kar = 0;
        int las = 0;



        do
        {

            ruch++;

        }
        while (ruch < 2);


        do
        {

            kar++;

        }
        while (kar < 8);

        do
        {


            las++;
        }

        while (las < 20);


        int u = las + ruch + kar;

        if (cruch * ruch + clas * las + ckar * kar == 100)
        {
            Console.WriteLine("Ручек: " + ruch);
            Console.WriteLine("Карандашей: " + kar);
            Console.WriteLine("Ластиков: " + las);
            Console.WriteLine("Всего: " + u);


        }

        else
        {
            Console.WriteLine("error");
        }


    }
}


