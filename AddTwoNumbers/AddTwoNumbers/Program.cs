using System;

namespace addtwonumbers
{
    public class Myreality
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);
            int result = num1 + num2;
            Console.WriteLine(result);
        }
    }
}