using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace a
{
    class b
    {
        static void Main(string[] args)
        {
            int rods = Convert.ToInt32(Console.ReadLine()); //läser första raden
            int result = 0;				//Deklarer variablen för pillarna

        for (int i = 0; i < rods; i++)				//
            {
                result += Convert.ToInt32(Console.ReadLine());   //plussar i ihop rad för rad
            }

        Console.WriteLine(result - rods + 1);
        }
    }
}


// https://open.kattis.com/problems/jumbojavelin