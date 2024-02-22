using System;
namespace hissingmicrophone
{
    public class Myreality
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string hiss = "ss";
            if ( word.Contains(hiss))// this is too look for the ss so it can print out hiss
            {
                Console.WriteLine("hiss");
            }
            else
            {
                Console.WriteLine("no hiss");
            }

        }
    }
}