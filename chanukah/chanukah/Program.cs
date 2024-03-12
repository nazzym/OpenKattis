namespace chanukah
{
    internal class Program
    {
        static void Main()
        {
            int holidays = int.Parse(Console.ReadLine()); // Total datasets
  string[] days = new string[holidays]; 
  for (int i = 0; i < holidays; i++) 
  {
      Console.WriteLine("please enter the amount of days of this holiday");
      days[i] = Console.ReadLine();

      int count = 1;
     for ( int j = 1;  j > count; j++ )
      {

      Console.WriteLine(count);
      }
      
      
    
      
  }
        }
    }
}
