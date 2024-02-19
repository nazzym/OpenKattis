using System;
namespace Myreality
{
    public class Myworld
    {
        public static void Main()
        {
            int rooms = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int teams = people / rooms;
            int remainder = people % rooms;
            for (int i = 0; i < rooms; i++)
            {
                for (int j = 0; j < teams; j++)
                {
                    Console.Write("*");
                }
                if (remainder > 0)
                {
                    Console.Write("*");
                    remainder--;
                }
                Console.WriteLine();
            }
        }

    }
    }
     
