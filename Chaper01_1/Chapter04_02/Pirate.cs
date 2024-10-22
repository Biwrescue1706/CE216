using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_02
{
    class Pirate
    {
        private string name;
        private int health;
        private int attackPower;
        private Random rdr;

        public Pirate(string name)
        {
            this.name = name;
            rdr = new Random();
            this.health = rdr.Next(1000, 2001);
            this.attackPower = rdr.Next(200, 301);
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Health: {0}", this.health);
            Console.WriteLine("AttackPower: {0}", this.attackPower);
        }

        private int RandomAttackPower()
        {
            return rdr.Next(100, this.attackPower + 1);
        }

        public void Fight(Pirate enemy)
        {
            while (this.health >= 0 && enemy.health >= 0)
            {
                int myAttackPower = RandomAttackPower();
                int enemyAttackPower = enemy.RandomAttackPower();
                Console.WriteLine("{0} Attack Power: {1}", this.name, myAttackPower);
                Console.WriteLine("{0} Attack Power: {1}", enemy.Name, enemyAttackPower);
                this.health = this.health - enemyAttackPower;
                enemy.Health = enemy.Health - myAttackPower;
                Console.WriteLine("{0} health after fight: {1}", this.name, this.health);
                Console.WriteLine("{0} health after fight: {1}", enemy.Name, enemy.Health);
            }
            if (this.health >= 0)
            {
                Console.WriteLine("{0} win!!!", this.name);
            }
            else if (enemy.health >= 0)
            {
                Console.WriteLine("{0} win!!!", enemy.name);
            }
        }
    }
}
