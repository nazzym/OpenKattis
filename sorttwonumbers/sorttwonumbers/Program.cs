namespace sorttwonumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string[] res = number.Split(' ');
            int num1 = int.Parse(res[0]);
            int num2 = int.Parse(res[1]);


            if (num1 < num2)
            {
                Console.WriteLine(num1 + " " + num2);

            }
            else 
            {
                Console.WriteLine(num2 + " "+ num1);
                
            }
        }
    }
}
