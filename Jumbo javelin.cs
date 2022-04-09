using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace a
{
    class b
    {
        static void Main(string[] args)
        {
            int rods = Convert.ToInt32(Console.ReadLine()); 
            int result = 0;			
            
        for (int i = 0; i < rods; i++)				
            {
                result += Convert.ToInt32(Console.ReadLine());  

        Console.WriteLine(result - rods + 1);
        }
    }
}


// https://open.kattis.com/problems/jumbojavelin
