using System;

namespace nsum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());// how many numbers to be added
            string numbers = Console.ReadLine();
            int[] number = Array.ConvertAll(numbers.Split(' '), int.Parse);//make it into an array and into an int
            //setting the variables
            int sum = 0;
            int count = 0;
            //using num to identify numbers instead of having to you use they places with index
            foreach (int num in number)
            {//when the input is bigger than count sum it all up if not then break
                if (count < input)
                {
                    sum += num;
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}