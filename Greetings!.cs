using System;
public class Exercise2
{
    public static void Main()
    {

        string firsthey = Console.ReadLine();

        string e1 = firsthey.Substring(1, firsthey.Length -2);

        string resultat = "";

        for (int i = 0; i < e1.Length*2; i++)
        {
            resultat += "e";
        }
        Console.WriteLine("H" + resultat  + "y");
    }
}



// https://open.kattis.com/problems/greetings