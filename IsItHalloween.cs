using System;
public class Exercise2
{
    public static void Main()
    {
        string input = Console.ReadLine();

        if (input == "DEC 25" || input == "OCT 31")
        {
            Console.WriteLine("yup");
        }
        else
        {
            Console.WriteLine("nope");
        }
    }
}


// https://open.kattis.com/problems/isithalloween