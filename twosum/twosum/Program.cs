using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace twosum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string numbers = Console.ReadLine();
            int[] number = Array.ConvertAll(numbers.Split(' '), int.Parse);
            int sum = 0;
            
            
            foreach (int num in number) 
            
            {
            sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
