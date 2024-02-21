// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int numstones = int.Parse(Console.ReadLine());
while  ( numstones > 1)
    if (numstones % 2 == 0) 
             {

        numstones -= 2;
            }
else
    {
        numstones -= 1;
    }
string winner;
if (numstones == 1)
    winner = "Alice";
else 
    winner = "Bob";
Console.WriteLine(winner);

