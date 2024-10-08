using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hradgreining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dna = "COV";
            string input = Console.ReadLine();
            if (input.Contains( dna))
            {
                Console.WriteLine("Veikur!");
            }
            else
            {
                Console.WriteLine("Ekki veikur!");
            }
        }
    }
}
