using System;
namespace twostones
{
    public class Myreality
    {
        public static void Main()
        {
            int numstones = int.Parse(Console.ReadLine());
            string winner = "";
            while (numstones > 1)
            {
                if (numstones % 2 == 0)
                {
                    numstones -= 2;
                    winner = "Bob";
                }
                else
                {
                    numstones = 1;
                    winner = "Alice";
                }
            }

            if (numstones == 1)
            {
                winner = "Alice";
            }

            Console.WriteLine(winner);
        }
    }
}