using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace a
{
    class b
    {
        static void Main(string[] args)
        {

            int a; 
            a = Convert.ToInt32(Console.ReadLine());


            if (a%2== 0)   //Checkar ifall det är ett jämnt tal
            {
                Console.WriteLine("Bob");
            }
            else
            {
                Console.WriteLine("Alice");
            }
        }
    }
}


// https://open.kattis.com/problems/twostones