using System;
public class Exercise2
{
    public static void Main()
    {

        char[] vowels =  { 'A', 'E', 'I', 'O', 'U' };

        string searchletter = Console.ReadLine().ToUpper();

        int total = 0;

        for (int i = 0; i < searchletter.Length; i++)
        {
            foreach(char c in vowels)
            {
                if (searchletter[i] == c) total++;
            }
        }
        Console.WriteLine(total);
    }
}


// https://open.kattis.com/problems/countthevowels