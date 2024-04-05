using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ofugsnuid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];
            int i = 0;
            while (i < number)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                i++;
            }
           
            Array.Reverse(numbers);


            foreach(int num in numbers)
            {
                Console.WriteLine(num +" ");
            }
           
        }
    }
}
