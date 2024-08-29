using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimaldeletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            if (input - Math.Floor(input )<= 0.5)
            {
                Console.WriteLine(Math.Floor(input));
            }
            else
            {
                Console.WriteLine(Math.Ceiling(input));
            }
        }
    }
}
