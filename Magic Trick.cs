using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sameLetter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j]) sameLetter++;

                    if (sameLetter > 1) break;
                }
                if (sameLetter > 1) break;
                sameLetter = 0;
            }
            if (sameLetter < 1) Console.WriteLine("1"); else Console.WriteLine("0");
        }
    }
}


// https://open.kattis.com/problems/magictrick