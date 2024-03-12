using System;

namespace Chanukah
{
    internal class Program
    {
        static void Main()
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            int numHolidays = int.Parse(Console.ReadLine());
            int[] candlesPerDay = new int[numHolidays];

            for (int i = 0; i < numHolidays; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int day = int.Parse(line[0]);
                int candles = int.Parse(line[1]);
                candlesPerDay[day - 1] = candles;
            }

            int totalCandles = 0;
            for (int i = 0; i < numHolidays; i++)
            {
                totalCandles += candlesPerDay[i];
                Console.WriteLine($"{i + 1} {totalCandles}");
            }
=======
            int holidays = int.Parse(Console.ReadLine()); // Total datasets
  string[] days = new string[holidays]; 
  for (int i = 0; i < holidays; i++) 
  {
      Console.WriteLine("please enter the amount of days of this holiday");
      days[i] = Console.ReadLine();

=======
            int holidays = int.Parse(Console.ReadLine()); // Total datasets
  string[] days = new string[holidays]; 
  for (int i = 0; i < holidays; i++) 
  {
      Console.WriteLine("please enter the amount of days of this holiday");
      days[i] = Console.ReadLine();

>>>>>>> 1bfde2dd4ef8c044786475a9b4db4fa49fbb927c
=======
            int holidays = int.Parse(Console.ReadLine()); // Total datasets
  string[] days = new string[holidays]; 
  for (int i = 0; i < holidays; i++) 
  {
      Console.WriteLine("please enter the amount of days of this holiday");
      days[i] = Console.ReadLine();

>>>>>>> 1bfde2dd4ef8c044786475a9b4db4fa49fbb927c
      int count = 1;
     for ( int j = 1;  j > count; j++ )
      {

      Console.WriteLine(count);
      }
      
      
    
      
  }
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 1bfde2dd4ef8c044786475a9b4db4fa49fbb927c
=======
>>>>>>> 1bfde2dd4ef8c044786475a9b4db4fa49fbb927c
=======
>>>>>>> 1bfde2dd4ef8c044786475a9b4db4fa49fbb927c
        }
    }
}
