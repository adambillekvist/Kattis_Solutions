using System;
public class Exercise2
{
    public static void Main()
    {
        string [] a = Console.ReadLine().Split(" ");

        int a1 = Convert.ToInt32(a[0]);
        int a2 = Convert.ToInt32(a[1]);

        Console.WriteLine((a2 * 2) - a1);

    }
}



//  https://open.kattis.com/problems/r2