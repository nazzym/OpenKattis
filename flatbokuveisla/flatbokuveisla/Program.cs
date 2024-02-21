using System;
namespace flatbokuveisla
{
    public class Myreality
    {
        public static void Main()
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int remainder, quotient = Math.DivRem(input1,input2, out remainder);
            Console.WriteLine(remainder);
        }
    }
}