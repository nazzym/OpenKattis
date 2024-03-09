namespace jackolanternjuxtaposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);
            int num3 = int.Parse(numbers[2]);
            int result = num1 * num2 * num3;
            Console.WriteLine (result); 
        }
    }
}
