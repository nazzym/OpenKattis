using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shortcuttowhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int .Parse(Console.ReadLine());
            int stage1 = number + 5;
            int stage2 = stage1 * 3;
            int stage3 = stage2 - 10;
            Console.WriteLine(stage3);
        }
    }
}
