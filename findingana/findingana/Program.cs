namespace findingana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // user input in string
            int index = input.IndexOf('a');//finding the first encounter with the letter a

            if(index !=-1)//checking if the letter a was found in the input string 
            {
                Console.WriteLine(input.Substring(index));// if it was then extract and print the substring of the input starting from the index of the first occurrence of a
            }
        }
    }
}
