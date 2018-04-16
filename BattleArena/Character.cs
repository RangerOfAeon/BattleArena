using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    class Character
    {
        Program characterProgram = new Program();
        public static Random YouRng = new Random();

        public static int Str = YouRng.Next(1, 7);
        public static int Dmg = YouRng.Next(1, 7);
        public static int Hp = YouRng.Next(1, 11);

        public void YourStats()
        {
            Program.YourStr = Str;
            Program.YourDmg = Dmg;
            Program.YourHp = Hp;
        }
        public void WriteStats()
        {
            Console.WriteLine("Strength: " + Program.YourStr);
            Console.WriteLine("Damage: " + Program.YourDmg);
            Console.WriteLine("Health: " + Program.YourHp);
        }
    

        public void YourName()
        {
            Console.WriteLine("What's you name?");
            Program.YourName = Console.ReadLine();
            Console.Clear();
        }
        public void ReadName()
        {
            Console.WriteLine("Name :" + Program.YourName);
        }
   
        public void FoeStats()
        {
            Random FoeRng = new Random();
            Program.FoeStr = FoeRng.Next(1, 7);
            Program.FoeDmg = FoeRng.Next(1, 7);
            Program.FoeHp = FoeRng.Next(1, 11);
            Console.WriteLine("Stength: " + Program.FoeStr);
            Console.WriteLine("Damage: " + Program.FoeDmg);
            Console.WriteLine("Health: " + Program.FoeHp);

        }

        //public void Retire()
        //{
        //    public string yourHp
        //{
        //    get { return YourHp; }
        //}
        //    if(YourHp)
        //}
        }
    }

