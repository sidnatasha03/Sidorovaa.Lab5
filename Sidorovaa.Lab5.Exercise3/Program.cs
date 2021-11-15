using System;

namespace Sidorova.Lab5.Exercise3;
class Program
{
    static void Main(string[] args)
    {

        int cr = 10;
        int ck = 5;
        int cl = 2;
        int sum = 100;


        int r = 0;
        int k = 0;
        int l = 0;

        for (r = 0; r <= 30; r++)
        {
            for (l = 0; l <= 30; l++)
            {
                for (k = 0; k <= 30; k++)
                {
                    if (l + r + k == 30 & cr * r + cl * l + ck * k == 100)
                    {
                        Console.WriteLine("Количество ручек:" + r);
                        Console.WriteLine("Количество ластиков:" + l);
                        Console.WriteLine("Количество карандашей:" + k);
                    }
                   
                }
            }
        }
    }
}
