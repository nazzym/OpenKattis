using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace fyi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string res = str.Substring(0, 3);
            int number = int.Parse(str);
           int x = 555;
            int one = 1;
            int zero = 0;

            if (number == x)
            {
                Console.WriteLine(one);

                
               


            }
            else
            {
                Console.WriteLine(zero);
            }
        }
    }
}
