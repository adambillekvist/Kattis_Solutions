using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(" ");
            int a1 = Convert.ToInt32(a[0]);
            int a2 = Convert.ToInt32(a[1]);

            if (a1 >= 0 && a2 >= 0)
            {
                if (a1 > a2 && a1 <= 1000000)
                {
                    Console.WriteLine($"{a2} {a1}");
                }
                else if (a1 < a2 && a2 <= 1000000)
                {
                    Console.WriteLine($"{a1} {a2}");
                }
                else
                {
                    Console.WriteLine($"{a1} {a2}");
                }
            }
        }
    }
}



// https://open.kattis.com/problems/sorttwonumbers