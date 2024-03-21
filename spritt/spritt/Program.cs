namespace spritt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int num1 = int.Parse(numbers[0]);   
            int num2 = int.Parse(numbers[1]);
            int count = 0;
            int i = 0;
            
            while (num1 > i)
            {
                int result = int.Parse(Console.ReadLine());
                i++;
                count+=result;
            }

            if (num2 > count)
            {
                Console.WriteLine("Jebb");
            }
            else if  (num2 == count)
            {
                Console.WriteLine("Jebb");
            }
            else
            {
                Console.WriteLine("Neibb");
            }
           
        }
    }
}
