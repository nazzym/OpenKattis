using System;
namespace aleidibio
{
    class Myreality
    {
        public static void Main()
        {
            int line1 = int.Parse(Console.ReadLine());
            int line2 = int.Parse(Console.ReadLine());
            int line3 = int.Parse(Console.ReadLine());
            int result = (line3) - (line1 + line2);
            Console.WriteLine(result);

        }
    }
}