using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_02
{
    class PirateGang
    {
        private string gangName;
        private int member;
        private List<Pirate> pirates;
        private Random rdr;

        public PirateGang(string gangName, int member)
        {
            this.gangName = gangName;
            this.member = member;
            pirates = new List<Pirate>();
            rdr = new Random();
        }

        public string GangName
        {
            get { return this.gangName; }
            set { this.gangName = value; }
        }

        public int Member
        {
            get { return this.member; }
            set { this.member = value; }
        }

        public void AddPirate(Pirate pirateMember)
        {
            pirates.Add(pirateMember);
        }

        public Pirate PickupPirate()
        {
            return pirates[rdr.Next(0, member)];
        }

        public void PrintDetail()
        {
            Console.WriteLine("Name of gang: {0}", this.gangName);
            foreach (Pirate pirate in pirates)
            {
                pirate.PrintDetails();
            }
        }
    }
}
