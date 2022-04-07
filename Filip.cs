using System;
public class Exercise2
{
    public static void Main()
    {
        string [] a = Console.ReadLine().Split(" ");

        string a1 = (a[0]);
        string a2 = (a[1]);

        string reverseda1 = "";
        string reverseda2 = "";

        for (int i = 2; i > -1; i--)
        {
            reverseda1 += a1[i];
            reverseda2 += a2[i];
        }

        if (Convert.ToInt32(reverseda1) > Convert.ToInt32(reverseda2))
        {
            Console.WriteLine(reverseda1);
        }
        else
        {
            Console.WriteLine(reverseda2);
        }
    }
}


// https://open.kattis.com/problems/filip