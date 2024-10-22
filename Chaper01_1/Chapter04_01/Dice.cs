using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_01
{
    class Dice
    {
        private int die;
        private int face;
        private Random rnd;

        public int Face
        {
            get { return face; }
            set { face = value; }
        }
        public Dice()
        {
            face = 6;
            rnd = new Random();
            die = rnd.Next(1, 7);
        }
        public Dice(int f)
        {
            face = f;
            rnd = new Random();
            rnd.Next(1,face+1);
        }
        public int RollDice() 
        { 
            die = rnd.Next(1,face+1);
            return die;
        }
    }
}
