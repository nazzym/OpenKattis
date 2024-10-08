using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipphipphurra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string hiphip = "Hipp hipp hurra, ";
            int i = 1;
           while (i <= age)
            {
                Console.WriteLine(hiphip + name + "!");
                
                i++;
            }
            
        }
    }
}
