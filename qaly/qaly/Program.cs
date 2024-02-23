using System;

class Myreality
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());// convert to number

        decimal[][] periods = new decimal[n][];// two dimensional array with decimal values named period

        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split();// splits into an array of strings using the whitespace 
            periods[i] = new decimal[] { decimal.Parse(line[0]), decimal.Parse(line[1]) };
        }

        decimal qalys = 0;

        for (int i = 0; i < n; i++)
        {
            qalys += periods[i][0] * periods[i][1];
        }

        Console.WriteLine(qalys);


    }
}