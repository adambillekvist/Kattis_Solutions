using System;
public class Exercise2
{
    public static void Main()
    {

        string [] a = Console.ReadLine().Split(" ");

        int Fizz = Convert.ToInt32(a[0]);
        int Buzz = Convert.ToInt32(a[1]);
        
        for (int i = 1; i < Convert.ToInt32(a[2])+1; i++)
        {
            if (i % Buzz == 0 && i % Fizz == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % Fizz == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % Buzz == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}


//  https://open.kattis.com/problems/fizzbuzz