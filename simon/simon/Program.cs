using System;
using System.Collections.Generic;

namespace simonsays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> commands = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                string Simon = "simon says";

                if (input.StartsWith(Simon + " ")) // Ensuring "Simon says" is followed by a space
                {
                    commands.Add(input.Substring(Simon.Length).Trim());
                }
                else
                {
                    commands.Add(""); // Ensure a truly blank line for non-matching inputs
                }
            }

            foreach (string command in commands)
            {
                Console.WriteLine(command); // Outputs either the command following "Simon says" or a blank line
            }
        }
    }
}
