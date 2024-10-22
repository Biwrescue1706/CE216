using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_02
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Number of gang to create: ");
            int numOfGangs = Convert.ToInt32(Console.ReadLine());
            List<PirateGang> gangs = new List<PirateGang>();
            for (int i = 0; i < numOfGangs; i++)
            {
                Console.Write("Please enter name of gang: ");
                string gangName = Console.ReadLine();
                Console.Write("Please enter number of member:");
                int member = Convert.ToInt32(Console.ReadLine());
                PirateGang pirateGang = new PirateGang(gangName, member);
                gangs.Add(pirateGang);
            }

            foreach (PirateGang p in gangs)
            {
                Console.WriteLine("Name of gang: {0} ", p.GangName);
                for (int i = 0; i < p.Member; i++)
                {
                    Console.Write("Please enter name of pirate {0}: ", i + 1);
                    string pirateName = Console.ReadLine();
                    Pirate pirate = new Pirate(pirateName);
                    p.AddPirate(pirate);
                }
            }

            Console.WriteLine("=============================");

            foreach (PirateGang p in gangs)
            {
                p.PrintDetail();
                Console.WriteLine("******************************");
            }

            Console.WriteLine("=============================");

            Random random = new Random();
            int randomGang1 = random.Next(0, numOfGangs);
            int randomGang2 = random.Next(0, numOfGangs);

            PirateGang myGang = gangs[randomGang1];
            PirateGang enemyGang = gangs[randomGang2];

            Pirate me = myGang.PickupPirate();
            Pirate enemy = enemyGang.PickupPirate();

            Console.WriteLine("{0} Fight {1}", me.Name, enemy.Name);
            me.Fight(enemy);
        }
    }
}
