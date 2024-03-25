using System;

namespace ReverseBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input integer
            int number = int.Parse(Console.ReadLine());

            // Convert the number to its binary representation as a string
            string binaryString = Convert.ToString(number, 2);

            // Reverse the binary string
            char[] binaryArray = binaryString.ToCharArray();
            Array.Reverse(binaryArray);
            string reversedBinaryString = new string(binaryArray);

            // Convert the reversed binary string back to an integer
            int reversedNumber = Convert.ToInt32(reversedBinaryString, 2);

            // Output the reversed number
            Console.WriteLine(reversedNumber);
        }
    }
}
