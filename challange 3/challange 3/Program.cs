using System;
using System.Text;

class MechDefenseSimulator
{
    static void Main()
    {
        string monsterMoves = Console.ReadLine();
        StringBuilder mechMoves = new StringBuilder();
        bool r = false, b = false, l = false;

        foreach (char move in monsterMoves)
        {
            switch (move)
            {
                case 'R':
                    if (!r)
                    {
                        r = true;
                        if (b && l)
                        {
                            mechMoves.Append('C');
                            r = b = l = false; // Reset after a combo
                        }
                    }
                    else
                    {
                        mechMoves.Append('S'); // Counter directly if it's a repeated move or no combo possible
                    }
                    break;
                case 'B':
                    if (!b)
                    {
                        b = true;
                        if (r && l)
                        {
                            mechMoves.Append('C');
                            r = b = l = false; // Reset after a combo
                        }
                    }
                    else
                    {
                        mechMoves.Append('K'); // Counter directly if it's a repeated move or no combo possible
                    }
                    break;
                case 'L':
                    if (!l)
                    {
                        l = true;
                        if (r && b)
                        {
                            mechMoves.Append('C');
                            r = b = l = false; // Reset after a combo
                        }
                    }
                    else
                    {
                        mechMoves.Append('H'); // Counter directly if it's a repeated move or no combo possible
                    }
                    break;
            }

            // After checking for combos, counter any moves not part of a combo
            if (r && mechMoves.Length == 0 || mechMoves[^1] != 'C')
            {
                if (r) { mechMoves.Append('S'); r = false; }
                if (b) { mechMoves.Append('K'); b = false; }
                if (l) { mechMoves.Append('H'); l = false; }
            }
        }

        Console.WriteLine(mechMoves.ToString());
    }
}
