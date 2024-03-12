using System.ComponentModel.Design;

namespace kikiiboba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //read line of text of user
            string input = Console.ReadLine();

            int bCount = 0;
            int kCount = 0;

            foreach (char c in input)
            {
                if (char.ToLower(c) == 'b')
                {
                    bCount++;
                }
                else if (char.ToLower(c) == 'k')
                {
                    kCount++;
                }
            } /// vfreorjkd

            if (bCount > kCount)
            {
                Console.WriteLine("boba");
            }
            else if ((bCount <= 0) && (kCount <= 0)) 
            {
                Console.WriteLine("none");
            }
            else if (kCount > bCount)
            {
                Console.WriteLine("kiki");
            }
            else if (bCount == kCount)
            {
                Console.WriteLine("boki");
            }
           


            // wokrs
        }

    }
    
}
