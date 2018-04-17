using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    class Battle
    {
        Character battleCharacter = new Character();            // Här kallar jag på instanser från de andra klasserna.
        Program battleProgram = new Program();
        Round battleRound = new Round();
        public void Choice()
        {
            while (Program.YourHp > 0)
            {
                battleCharacter.ReadName();                         // 
                battleCharacter.WriteStats();
                Console.WriteLine("Press F to fight.");
                Console.WriteLine("Press R to retire.");
                    var choose = Console.ReadKey();
                    switch (choose.Key)
                    {
                        case ConsoleKey.F:
                            Console.Clear();
                            battleCharacter.FoeGenerator();
                            Console.WriteLine(Program.YourName);
                            battleCharacter.WriteStats();
                            Console.WriteLine();
                            Console.WriteLine(Program.foeName);
                            battleCharacter.FoeStats();
                            Console.WriteLine();
                            Console.ReadKey();
                            while (Program.YourHp > 0 && Program.FoeHp > 0)
                            {
                                battleRound.Dice();
                                battleRound.OneRound();
                                Console.ReadKey();
                            }
                            if (Program.YourHp > 0)
                            {
                                Console.WriteLine("You won!");
                                Program.Score = Program.Score + 5;
                                Program.FoeNames.Add(Program.foeName);
                                Console.ReadKey();
                                Console.Clear();

                            }
                            else
                            {
                                Console.WriteLine("You died.");
                                Console.ReadKey();
                                Console.Clear();
                                battleCharacter.Retire();
                                Console.ReadKey();
                                return;
                            }
                            break;
                        case ConsoleKey.R:
                        Console.Clear();
                        battleCharacter.Retire();
                        Console.ReadKey();
                        return;
                        default:
                            Console.Clear();
                            Console.WriteLine("Please try again");
                            Console.WriteLine();
                            break;
                    }

               

            }
        }
    }
}
