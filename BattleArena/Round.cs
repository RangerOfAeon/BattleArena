using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    class Round
    {
        int YourDice = Program.YourDice;
        int YourStr = Program.YourStr;
        int YourDmg = Program.YourDmg;
        int YourHp = Program.YourHp;

        int FoeDice = Program.FoeDice;
        int FoeStr = Program.FoeStr;
        int FoeDmg = Program.FoeDmg;
        int FoeHp = Program.FoeHp;

        public void Dice()
        {
            Random DiceRng = new Random();
            int dice = DiceRng.Next(1, 7);
            Program.YourDice = dice;
        }
        public void BadDice()
        {
            Random DiceRng = new Random();
            int dice = DiceRng.Next(1, 7);
            Program.FoeDice = dice;
        }

        public void OneRound()
        {
            int YourResult = Program.YourStr + Program.YourDice;
            int FoeResult = Program.FoeStr + Program.FoeDice;
            if(YourResult > FoeResult)
            {
                Program.FoeHp = Program.FoeHp - Program.YourDmg;
                Program.FoeHp = FoeHp;
                Console.WriteLine("Good" + YourResult + " > " + FoeResult);
                YourResult = YourResult - YourResult;
                FoeResult = FoeResult - FoeResult;
            }
            else if(FoeResult > YourResult)
            {
                Program.YourHp = Program.YourHp - Program.FoeDmg;
                Program.YourHp = YourHp;
                Console.WriteLine("Bad" + FoeResult + " > " + YourResult);
                YourResult = YourResult - YourResult;
                FoeResult = FoeResult - FoeResult;
            }
            else
            {
                Console.WriteLine("You stare eachother down, and nobody attacks.");
            }
        }
    }
}
