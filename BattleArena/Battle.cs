using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    class Battle
    {
        Character battleCharacter = new Character();            // Här kallar konsolen på instanser från de andra klasserna.
        Program battleProgram = new Program();
        Round battleRound = new Round();
        public void Choice()                                    // Här börjar metoden som spelaren för välja om den vill slåss eller gå i pension, och det är i 
        {                                                       // den här metod som använder nästan alla metoder i de andra klasserna.
            while (Program.YourHp > 0)
            {
                battleCharacter.ReadName();                     // Här skriver konsolen ut spelarens namn och stats, coh här får man välja om man vill slåss eller    
                battleCharacter.WriteStats();                   // gå i pension.
                Console.WriteLine("Press F to fight.");
                Console.WriteLine("Press R to retire.");
                    var choose = Console.ReadKey();
                    switch (choose.Key)
                    {
                        case ConsoleKey.F:                                          // Om man väljer för att slåss, så ger konsolen ett namn åt motstådaren, och 
                            Console.Clear();                                        // och sedan så skriver konsolen ut spelarens namn och stats, och likadant för 
                            battleCharacter.FoeGenerator();                         // motståndaren.

                            battleCharacter.ReadName();
                            battleCharacter.WriteStats();
                            Console.WriteLine();

                            Console.WriteLine(Program.foeName);
                            battleCharacter.FoeStats();
                            Console.WriteLine();

                            Console.ReadKey();
                            while (Program.YourHp > 0 && Program.FoeHp > 0)         // Här börjar slagsmålet, och innan varje rond så ger metoden dice ett nytt  
                            {                                                       // värde, och slagsmålet fortsättter tills antingen spelaren eller 
                                battleRound.Dice();                                 // motståndaren har 0 health eller mindre.
                                battleRound.OneRound();
                                Console.ReadKey();
                            }
                            if (Program.YourHp > 0)
                            {
                                Console.WriteLine("You won!");                      // Om du vinner, så skriver konsolen att du har vunit, ger dig 5 poäng, och lägger
                                Program.Score = Program.Score + 5;                  // till motsådarens namn som du besegrade till en lista, och sen loopar den 
                                Program.FoeNames.Add(Program.foeName);              // tillbaka.

                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("You died.");                     // Om spelaren dör, så skriver konsolen att du har dött, och sedan skriver ut ditt
                                Console.ReadKey();                                  // namn, dina stats, vem som dödade dig och hur mycket poäng du fick. Sedan stängs
                                Console.Clear();                                    // konsolen av.

                                battleCharacter.Retire();
                                Console.ReadKey();
                                return;
                            }
                            break;
                        case ConsoleKey.R:                                          // Om man väljer att gå i pension, så skriver konsolen ut ditt namn, dina stats,
                        Console.Clear();                                            // att du överlevde, hur mycket poäng du fick och hur mycket poäng du fick. Sedan    
                        battleCharacter.Retire();                                   // stängs konsollen ner.
                        Console.ReadKey();
                        return;
                        default:
                            Console.Clear();                                        // Om spelaren råkar trycka fel på menyn, så ber programmet att man ska pröva igen
                            Console.WriteLine("Please try again");                  // tills man har valt rätt.
                            Console.WriteLine();
                            break;
                    }

               

            }
        }
    }
}
