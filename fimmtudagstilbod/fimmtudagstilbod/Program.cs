using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace fimmtudagstilbod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            int price = 1000;
            int year = 2020;
            int increase = 100;

            int Cal =  years - year;
            if (Cal < 0) Cal = 0;
            int result = Cal * increase +price;
            Console.WriteLine( result );
        }
    }
}
