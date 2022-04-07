using System;
public class Exercise2
{
    public static void Main()
    {
        string [] aa = Console.ReadLine().Split(" ");

        int a = Convert.ToInt32(aa[0]);
        int b = Convert.ToInt32(aa[1]);
        int c = Convert.ToInt32(aa[2]);

        Console.WriteLine(a * b * c);
    }
}






// https://open.kattis.com/problems/jackolanternjuxtaposition