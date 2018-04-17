using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    class Round
    {
        public void Dice()
        {
            Random DiceRng = new Random();                                      // Här har jag en metod som skapar två tärningar som får ett värde emellan 1 - 6.
            int dice = DiceRng.Next(1, 7);                                      // Ena tärningen är till spelaren, andra är till motståndaren.
            Program.YourDice = dice;
            int badDice = DiceRng.Next(1, 7);
            Program.FoeDice = badDice;
        }
        public void OneRound()
        {
            int YourResult = Program.YourStr + Program.YourDice;                // Här börjar metoden för en runda av slagsmålet, och jag ger två variabler resultatet
            int FoeResult = Program.FoeStr + Program.FoeDice;                   // av spelares strength och tärningskastet, och likadant för motståndare.

            if (YourResult > FoeResult)
            {
                Program.FoeHp = Program.FoeHp - Program.YourDmg;
                Console.WriteLine("Your won the clash:");
                Console.WriteLine(YourResult + " (" + Program.YourStr + " + " + Program.YourDice + " )" + " > " + FoeResult + " (" + Program.FoeStr + " + " + Program.FoeDice + ")");
                Console.WriteLine("Your current health: " + Program.YourHp + " | " + "Foes current health: " + Program.FoeHp);
                Console.WriteLine();
                                                                                // Här kommer en if-sats som kollar om du har ett högre resultat än motsåndaren,
            }                                                                   // och då tar konsolen och räknar ut motsåndarens health minus spelarens damage.
            else if(FoeResult > YourResult)                                     // Sedan skriver konsolen att du har vunnit ronden, och visar resultat och
            {                                                                   // nuvarande health för både spelaren och motståndaren.
                Program.YourHp = Program.YourHp - Program.FoeDmg;   
                Console.WriteLine("Your lost the clash:");
                Console.WriteLine(YourResult + " (" + Program.YourStr + " + " + Program.YourDice + " )" + " < " + FoeResult + " (" + Program.FoeStr + " + " + Program.FoeDice + ")");
                Console.WriteLine("Your current health: " + Program.YourHp + " | " + "Foes current health: " + Program.FoeHp);
                Console.WriteLine();
            }                                                                   // Samma saker häder här som den koden ovanför, fast för om motståndaren
            else                                                                // har ett högre resultat än spelaren.
            {
                Console.WriteLine("You stare eachother down, and nobody attacks:");
                Console.WriteLine(YourResult + " (" + Program.YourStr + " + " + Program.YourDice + ")" + " = " + FoeResult + " (" + Program.FoeStr + " + " + Program.FoeDice + ")");
                Console.WriteLine("Your current health: " + Program.YourHp + " | " + "Foes current health: " + Program.FoeHp);
                Console.WriteLine();
            }                                                                   // Om spelaren och motståndaren har samma resultat, så skriver konsolen att 
        }                                                                       // ingen attackerar, och ingen blir skadad, och sedan skriver ut resultatet
    }                                                                           // och nuvarande health för både spelaren och motståndaren.
}
