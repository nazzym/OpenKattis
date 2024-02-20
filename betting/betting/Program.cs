using System;
namespace myreality
{
    class Bet
    {
        static void Main ()

        {
            string input = Console.ReadLine();
            float a = int.Parse(input);
            a = 100 - a;
            Console.WriteLine(1 + a / (100 - a));
            a = 100 - a;
            Console.WriteLine(1 + a / (100 - a));
        }
    }
}
