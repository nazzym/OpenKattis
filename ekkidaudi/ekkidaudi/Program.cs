namespace ekkidaudi
{
    internal class Program
    {
        static void Main(string[] args)


        {
            string input = Console.ReadLine();
            string[] numbers = input.Split('|');
            string num1 =(numbers[0]);
            string num2 = (numbers[1]);
            string input2 = Console.ReadLine();
            string[] numbers2 = input2.Split('|');
            string num3 = (numbers2[0]);
            string num4 = (numbers2[1]);

            string result = num1 + num3 ;
            string result2 = num2 + num4 ;
            Console.WriteLine(result + " " + result2);


        }
        
    }
}
