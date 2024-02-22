using System;
namespace r2
{
    public class Myreality
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] num = input.Split(' ');

            if (num.Length != 2)
            {
                Console.WriteLine("Invalid input. Please enter two numbers separated by a space.");
            }
            else
            {
                int n1 = int.Parse(num[0]);
                int n2 = int.Parse(num[1]);
                int result = n2 * 2 - n1;
                Console.WriteLine(result);
            }
        }
    }
}