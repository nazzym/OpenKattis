using System;

class MyReality
{
    public static void Main()
    {
        int amount = int.Parse(Console.ReadLine());
        int transactions = 0;

        // Process for 500 SEK
        transactions += amount / 500;
        amount %= 500;

        // Adjusting strategy to consider your examples explicitly
        // If after taking out 500s, we're left with >= 100, we proceed with the next steps
        if (amount >= 100)
        {
            // For amounts between 100 and 499 (inclusive), we can only use 200 SEK and 100 SEK transactions
            // Check if adding 200 SEK once more minimizes transactions based on the remainder
            if (amount > 400) // In cases where adding a 500 SEK instead of two 200 SEK transactions is more optimal
            {
                transactions += 1; // Add one more 500 SEK transaction to optimize
                amount -= 500; // Deduct that added 500 SEK from the current amount
            }

            // Now, distribute the remaining amount over 200 SEK and 100 SEK transactions
            transactions += amount / 200; // Count 200 SEK transactions
            amount %= 200;

            if (amount > 0) // Any remaining amount can be covered with a single 100 SEK transaction
            {
                transactions += 1;
            }
        }

        Console.WriteLine(transactions);
    }
}
