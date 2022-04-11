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
            double input = Convert.ToDouble(Console.ReadLine());

            double result = Math.Sqrt(input) * 4;

            Console.WriteLine(result);
        }
    }
}


// https://open.kattis.com/users/adam-billekvist/submissions/areal