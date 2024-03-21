namespace skruop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());
            int count = 7;
            int i = 0;
            string up = "Skru op!";
            string down = "Skru ned!";


            while (i < number)
            {

                string volume = Console.ReadLine();
                
                if (up == volume && count < 10)
                {
                    count++;

                }
                else if (down == volume && count > 0)
                {
                    count--;
                }
                i++;
            }

            int r =  count;
            Console.WriteLine(r);
        }
    }
}
