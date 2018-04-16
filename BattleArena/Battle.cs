using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    class Battle
    {
        Character battleCharacter = new Character();
        Program battleProgram = new Program();
        Round battleRound = new Round();
        public void Choice()
        {
          
            battleCharacter.ReadName();
            battleCharacter.WriteStats();
            Console.WriteLine("Press F to fight.");
            Console.WriteLine("Press R to retire.");
            while (Program.YourHp > 0)
            {
                var choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.F:
                        Console.Clear();

                        Console.WriteLine(Program.YourName);
                        battleCharacter.WriteStats();
                        Console.WriteLine();
                        battleCharacter.FoeStats();
                        Console.ReadKey();
                        while (Program.YourHp > 0 || Program.FoeHp > 0)
                        {
                            battleRound.Dice();
                            battleRound.BadDice();
                            battleRound.OneRound();
                            Console.ReadKey();
                        }
                        if (Program.YourHp > 0)
                        {
                            Console.WriteLine("You won!");
                        }
                        else
                        {
                            Console.WriteLine("You died");
                        }
                        break;
                    case ConsoleKey.R:
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        break;
                }

            }


        }
    }
}
