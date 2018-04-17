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
            Random DiceRng = new Random();
            int dice = DiceRng.Next(1, 7);
            Program.YourDice = dice;
            int badDice = DiceRng.Next(1, 7);
            Program.FoeDice = badDice;
        }
        public void OneRound()
        {
            int YourResult = Program.YourStr + Program.YourDice;
            int FoeResult = Program.FoeStr + Program.FoeDice;
            int YourStr = Program.YourStr;
            int YourDice = Program.YourDice;
            int FoeStr = Program.FoeStr;
            int FoeDice = Program.FoeDice;
            if(YourResult > FoeResult)
            {
                Program.FoeHp = Program.FoeHp - Program.YourDmg;
                Console.WriteLine("Your lost the clash:");
                Console.WriteLine(YourResult + " (" + YourStr + " + " + YourDice + " )" + " > " + FoeResult + " (" + FoeStr + " + " + FoeDice + ")");
                Console.WriteLine("Foes health: " + Program.FoeHp);
                Console.WriteLine();
            }
            else if(FoeResult > YourResult)
            {
                Program.YourHp = Program.YourHp - Program.FoeDmg;
                Console.WriteLine("Your lost the clash:");
                Console.WriteLine(FoeResult + " (" + FoeStr + " + " + FoeDice + ")" + " > " + YourResult + " (" + YourStr + " + " + YourDice + ")");
                Console.WriteLine("Your health: " + Program.YourHp);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("You stare eachother down, and nobody attacks:");
                Console.WriteLine(YourResult + " (" + YourStr + " + " + YourDice + ")" + " = " + FoeResult + " (" + FoeStr + " + " + FoeDice + ")");
                Console.WriteLine();
            }
        }
    }
}
