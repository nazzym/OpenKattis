using System;


namespace dagatal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month =  int.Parse(Console.ReadLine());
            int year = 2019;
            int daysinmonth = DateTime.DaysInMonth(year, month);
            Console.WriteLine(daysinmonth);

        }
    }
}
