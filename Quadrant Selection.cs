using System;
public class Exercise2
{
    public static void Main()
    {

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > 0 && b > 0)
        {
            Console.WriteLine(1);
        }
        else if (a < 0 && b > 0)
        {
            Console.WriteLine(2);
        }
        else if (a < 0 && b < 0)
        {
            Console.WriteLine(3);
        }
        else if (a > 0 && b < 0)
        {
            Console.WriteLine(4);
        }

    }
}

// https://open.kattis.com/problems/quadrant