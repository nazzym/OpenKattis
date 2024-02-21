using System;
namespace fifa
{
    public class Myreality
    {
        static void Main()
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int result = 2022 + (input1) / input2;
            Console.WriteLine(result);
        }
    }
}