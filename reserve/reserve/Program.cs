using System;

namespace reserve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberofinputs = int.Parse(Console.ReadLine());    
            List<int> numbers = new List<int> ();

            for (int i = 0;i < numberofinputs; i++) 
            { int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            numbers.Reverse();
            foreach (int number in numbers)
            { Console.WriteLine(number);
            }

        }
    }
}
