using System;
using System.Collections.Generic; // Needed for using the List

namespace simonsays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); // Number of commands to read
            int i = 0;
            List<string> commands = new List<string>(); // List to store commands that follow "Simon says"

            while (i < number)
            {
                string input = Console.ReadLine(); // User input in string
                string Simon = "Simon says";

                if (input.StartsWith(Simon))
                {
                    // Add everything after "Simon says" to the list
                    string command = input.Substring(Simon.Length).Trim(); // .Trim() to remove any leading or trailing spaces
                    commands.Add(command);
                }
                i++;
            }

            // Print all commands after exiting the loop
            foreach (string command in commands)
            {
                Console.WriteLine(command);
            }
        }
    }
}
