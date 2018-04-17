using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    class Character
    {
        Program characterProgram = new Program();                               // Här kallar jag på Program-instansen, och skapar en ny random instans, och skapar
        public static Random YouRng = new Random();                             // varibalerna som håller spelares stats.

        public static int Str = YouRng.Next(1, 7);
        public static int Dmg = YouRng.Next(1, 7);
        public static int Hp = YouRng.Next(1, 11);

        public void YourStats()
        {
            Program.YourStr = Str;                                              // Här aktiverar jag variablerna, och anger dom värden.
            Program.YourDmg = Dmg;
            Program.YourHp = Hp;
        }
        public void WriteStats()
        {
            Console.WriteLine("Strength: " + Program.YourStr);                  // Här skriver jag ut spelarens stats på konsolen.
            Console.WriteLine("Damage: " + Program.YourDmg);
            Console.WriteLine("Health: " + Program.YourHp);
        }


        public void YourName()
        {
            Console.WriteLine("What's you name?");                              // Här frågar jag spelaren vad den heter, och sparar det i en variabel.
            Program.YourName = Console.ReadLine();
            Console.Clear();
        }
        public void ReadName()
        {
            Console.WriteLine("Name :" + Program.YourName);                     // Här skriver jag ut namnet på konsolen.
        }

        public void FoeStats()
        {
            Random FoeRng = new Random();                                       // Här ger jag motsåndaren sina stats, och skriver ut dom på konsolen.
            Program.FoeStr = FoeRng.Next(1, 7);
            Program.FoeDmg = FoeRng.Next(1, 7);
            Program.FoeHp = FoeRng.Next(1, 11);
            Console.WriteLine("Stength: " + Program.FoeStr);
            Console.WriteLine("Damage: " + Program.FoeDmg);
            Console.WriteLine("Health: " + Program.FoeHp);
        }
        public void FoeGenerator()                                              // Här väljer metoden en siffra emellan 1 - 10, och beronde på vilken siffra det blir,
        {                                                                       // så får motsåndaren att annorlunda namn.
            Random FoeRandom = new Random();
            int FoeGen = FoeRandom.Next(1, 11);
            if (FoeGen == 1)
            {
                Program.foeName = "Isaac";
            }
            else if (FoeGen == 2)
            {
                Program.foeName = "Jason";
            }
            else if (FoeGen == 3)
            {
                Program.foeName = "Mikeal";
            }
            else if (FoeGen == 4)
            {
                Program.foeName = "Jens";
            }
            else if (FoeGen == 5)
            {
                Program.foeName = "Amir";
            }
            else if (FoeGen == 6)
            {
                Program.foeName = "Chaminda";
            }
            else if (FoeGen == 7)
            {
                Program.foeName = "Jonathan";
            }
            else if (FoeGen == 8)
            {
                Program.foeName = "Linus";
            }
            else if (FoeGen == 9)
            {
                Program.foeName = "Daniel";
            }
            else if (FoeGen == 10)
            {
                Program.foeName = "Krall";
            }
        }

        public void Retire()
        {
            Console.WriteLine("Your Name: " + Program.YourName);                    // Här skriver metoden ut spelarens stats, kollar om spelaren är död, och skriver
            Console.WriteLine("Your Strength: " + Program.YourStr);                 // då ut om du överlevde, eller vem du blev dödad av. Jag skriver också ut
            Console.WriteLine("Your Damage: " + Program.YourDmg);                   // hur mycket poäng spelaren får. Spelaren får 5 för varje motsådare han dödat,
            Console.WriteLine("Your Health: " + Program.YourHp);                    // 5 om spelaren överlevde och 1 pluspoäng för varje hp spelaren har kvar.
            if(Program.YourHp > 0)
            {
                Program.Score = Program.Score + Program.YourHp;
                Program.Score = Program.Score + 5;
                Console.WriteLine("You Survived.");
            }
            else
            {
                Console.WriteLine("Your were killed by: " + Program.foeName);
            }
            Console.WriteLine("Your Score: " + Program.Score);
            Console.WriteLine("You have killed:");
            Program.FoeNames.ForEach(Console.WriteLine);

        }

    }
}
