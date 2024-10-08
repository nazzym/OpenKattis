using System;

namespace oddecho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] inputs = new string[number];
            for (int i = 0; i < number; i++)
            {
                inputs[i] = Console.ReadLine(); 
            }
            for (int i = 0; i < number; i++)
            {
                if ((i+ 1) % 2 != 0)
                {
                    string[] words = inputs[i].Split(' ');
                    Console.WriteLine(words[0]);
                }
            }
        }
    }
}
