namespace addingtrouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//user inpuy
            string[] numbers = input.Split(' ');//doing this to tell apart the the numbers when on the same line

            int[] number = Array.ConvertAll(numbers, int.Parse);// putting it in the array its easier to find and locate 

            if (number[0] + number[1] == number[2])//we are locating it and doing the decelartions
            {
                Console.WriteLine("correct!");
            }
            else
            {
                Console.WriteLine("wrong!");
            }
        }
    }
}
