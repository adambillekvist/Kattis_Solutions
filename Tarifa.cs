using System;
public class Exercise2
{
    public static void Main()
    {
        int megabytesInPlan=Convert.ToInt32(Console.ReadLine());
        int months = Convert.ToInt32(Console.ReadLine());

        int result = 0;


        for (int i = 0; i < months; i++)
        {
            int used = Convert.ToInt32(Console.ReadLine());

            result += megabytesInPlan-used;
        }

        Console.WriteLine(result + megabytesInPlan);
    }
}




//  https://open.kattis.com/problems/tarifa