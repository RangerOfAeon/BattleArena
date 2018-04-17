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


            Character characterMain = new Character();                          // Här kallar jag instanser från de andra klasserna.
            Round roundMain = new Round();
            Battle battleMain = new Battle();

            characterMain.YourStats();                                          // Här kallar jag metoderna som anger spelaren sin stats, frågar efter spelares namn, 
            characterMain.YourName();                                           // och startar menyn där ma väljer om man ska slåss eller gå i pension. Koden fortsätter
            battleMain.Choice();                                                // till klassen Battle.
        }

             public static string YourName;                                     // Här är variablerna som jag använder för att spara spelarens och motståndarens namn, 
             public static int YourDice;                                        // Namnen på motståndare sm spelaren har dödat, strength, damage och health för både
             public static int FoeDice;                                         // spelaren och motståndarna, tärningarna och poäng som ges ut i slutet av spelet.

             public static int YourStr;
             public static int YourDmg;
             public static int YourHp;

             public static int FoeStr;
             public static int FoeDmg;
             public static int FoeHp;

             public static int Score;
             public static string foeName;
             public static List<string> FoeNames = new List<string>();


    }
    }

