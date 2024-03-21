namespace blandadbest
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int number = Int32.Parse(Console.ReadLine()); 
           string meat = Console.ReadLine();

            if (number == 1)
            {
                Console.WriteLine(meat);
            }
            else
            {
                Console.WriteLine("blandad best");
            }
        }
    }
}
