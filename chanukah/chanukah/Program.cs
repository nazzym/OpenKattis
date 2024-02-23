namespace chanukah
{
    internal class Program
    {
        static void Main()
        {
            int datasets = int.Parse(Console.ReadLine()); // Total datasets

            for (int dataset = 0; dataset < datasets; dataset++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                int holidayNumber = int.Parse(parts[0]);
                int days = int.Parse(parts[1]);

                int totalCandles = days * (days + 1) / 2 + days; // Total candles needed

                string output = $"{holidayNumber.ToString().PadLeft(5)} {totalCandles.ToString().PadLeft(5)}";
                Console.WriteLine(output);
            }
        }
    }
}