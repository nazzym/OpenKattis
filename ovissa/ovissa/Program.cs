using System;
class Myworld
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int uncertainty = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'u')
            {
                uncertainty++;
            }
        }

        Console.WriteLine(uncertainty);
    }
}