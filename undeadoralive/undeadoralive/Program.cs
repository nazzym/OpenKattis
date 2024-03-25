using System;

namespace ZombieDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input text
            string input = Console.ReadLine();

            // Check if the input contains smiley faces and frowny faces
            bool hasSmiley = input.Contains(":)");
            bool hasFrowny = input.Contains(":(");

            // Determine the type of message
            if (hasSmiley && !hasFrowny)
            {
                Console.WriteLine("alive");
            }
            else if (!hasSmiley && hasFrowny)
            {
                Console.WriteLine("undead");
            }
            else if (hasSmiley && hasFrowny)
            {
                Console.WriteLine("double agent");
            }
            else
            {
                Console.WriteLine("machine");
            }
        }
    }
}

