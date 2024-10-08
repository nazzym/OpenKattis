using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                int num = int.Parse(s);
                Console.WriteLine(s + " is " + (num % 2 == 0 ? "even" : "odd"));
            }
        }
    }
}
