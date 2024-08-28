using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takkar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trump = int.Parse(Console.ReadLine());
            int Kim = int.Parse(Console.ReadLine());
            if (trump > Kim)
            {
                Console.WriteLine("MAGA!");
            }
            else if (trump < Kim)
            {
                Console.WriteLine("FAKE NEWS!");

            }
            else
            {
                Console.WriteLine("WORLD WAR 3!");
            }
        }
    }
}
