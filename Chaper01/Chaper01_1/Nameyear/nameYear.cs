using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nameyear
{
    internal class nameYear
    {
        static void Main(string[] args)
        {
            string name;
            string surName;
            int age;
            int bornYear;

            Console.Write("Please enter your name : ");
            name = Console.ReadLine();
            Console.Write("Please enter your surname : ");
            surName = Console.ReadLine();
            Console.Write("Please enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());
            
            bornYear = DateTime.Now.Year - age;
            Console.Write("{0} {1} was born in {2}",name,surName,bornYear);
        }
    }
}
