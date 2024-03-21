using System;

namespace CipherTextTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string cipherText = Console.ReadLine().ToUpper(); // Read the input and convert it to upper case
            Console.WriteLine(DaysToChangeToPer(cipherText)); // Output the days needed
        }

        private static int DaysToChangeToPer(string cipher)
        {
            const string target = "PER"; // The target text
            int daysRequired = 0;        // Initialize the count of days required

            // Loop through the cipher text in chunks of three characters
            for (int i = 0; i < cipher.Length; i += 3)
            {
                // For each character in the chunk, compare it to the corresponding character in 'PER'
                for (int j = 0; j < 3; j++)
                {
                    // If the current character is not the same as the corresponding character in 'PER', increase the days
                    if (cipher[i + j] != target[j])
                    {
                        daysRequired++;
                    }
                }
            }

            return daysRequired; // Return the total days required
        }
    }
}

