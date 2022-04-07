using System;
public class Exercise2
{
    public static void Main()
    {
        string [] a = Console.ReadLine().Split(" ");

        decimal a1 = Convert.ToInt32(a[0]);
        decimal a2 = Convert.ToInt32(a[1]);

        Console.WriteLine((a1 * a2) / 2);

    }
}



// https://open.kattis.com/problems/triarea