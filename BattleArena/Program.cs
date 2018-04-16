using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    class Program
    {
        static void Main(string[] args)
        {


            Character characterMain = new Character();
            Round roundMain = new Round();
            Battle battleMain = new Battle();
            Program secondProgram = new Program();


            characterMain.YourStats();
            characterMain.YourName();

            battleMain.Choice();
        }

             public static string YourName;
             public static int YourDice;
             public static int FoeDice;

             public static int YourStr;
             public static int YourDmg;
             public static int YourHp;

             public static int FoeStr;
             public static int FoeDmg;
             public static int FoeHp;

    }
    }

