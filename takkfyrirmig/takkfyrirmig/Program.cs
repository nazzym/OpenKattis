using System;

namespace takkfyrirmig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = Int32.Parse(Console.ReadLine());
            int o = 0; // Initialize loop counter

            while (o < i) // Loop until o < i
            {
                string input = Console.ReadLine();
                string takk = "Takk ";
                Console.WriteLine(takk + input);
                o++; // Increment loop counter
            }
        }
    }
}

