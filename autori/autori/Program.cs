using System;

namespace ShortenNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] names = input.Split('-');
            string shortName = "";

            foreach (string name in names)
            {
                shortName += name[0];
            }

            Console.WriteLine(shortName);
        }
    }
}