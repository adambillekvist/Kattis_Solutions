using System;
public class Exercise2
{
    public static void Main()
    {

        int inputen = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < inputen; i++)
        {
            int b = Convert.ToInt32(Console.ReadLine());

            if (b % 2 == 0)
            {
                Console.WriteLine(b + " is even");
            }
            else
            {
                Console.WriteLine(b + " is odd");
            }
        }
    }
}







// https://open.kattis.com/problems/oddities