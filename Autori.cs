using System;

namespace Autori
{
    class Autori
    {
        static void Main(string[] args)
        {
            var names = EnterNames();

            string resultat = "";
            for (int i = 0; i < names.Length; i++)
            {
                resultat = resultat + FirstChar(names[i]);
            }

            Console.WriteLine(resultat);

        }
        private static string FirstChar(string str)
        {
            return str[0].ToString();


        }
        private static string[] EnterNames()
        {
            return Console.ReadLine().Split('-');
        }
        
    }           
}
   
