using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peresdacvhya_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            double s, i, P, O = 0;

            for (i = 1; i <= 18; i++)
            {
                s = i;
                N = Math.Pow(4, i);
                P = Pm(s, N);
                O = O + P;
                Console.WriteLine(P);
                Console.WriteLine(O);
            }

            //Console.WriteLine(O);
            Console.ReadKey();
        }
        static double streak(double n)
        {
            //ВНИМАНИЕ: ТАК КАК ЦИФРЫ ЗАОБЛАЧНЫЕ, Я ВЫВОЖУ В МЭЙНЕ  Р , О
            double k = 0, i = 1, z = 0, x = 0, j = 0;
            do
            {
                k++;
                z = n + k;
                x = k + 1;
                i = z % x;
                if (i != 0)
                { j = 0; }
                else
                { j = 1; }
            } while (j > 0);
            return k;
        }

        static double Pm(double s, double N)
        {
            double p = 0, st = 0;
            for (double i = 2; i < N; i++)
            {
                st = streak(i);
                if (st == s)
                { p++; }
            }
            return p;
        }


       

    }
}
