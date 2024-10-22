using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    class PersonCalculate
    {
        public static void Main(string[] args)
        {
            Person personObj1 = new Person();
            string bmiResult1 = personObj1.CalBmi();
            double bmrResult1 = personObj1.CalBmr();

            Console.WriteLine(personObj1);
            Console.WriteLine("Person 1");
            Console.WriteLine("BMI = {0} ", bmiResult1);
            Console.WriteLine("BMR = {0} ", bmrResult1);

            Console.WriteLine("----------------------------------------------------------------------------------");

            Person personObj2 = new Person(175,60,24,1);
            string bmiResult2 = personObj2.CalBmi();
            double bmrResult2 = personObj2.CalBmr();

            Console.WriteLine(personObj2);
            Console.WriteLine("Person 2");
            Console.WriteLine("BMI = {0} ", bmiResult2);
            Console.WriteLine("BMR = {0} ", bmrResult2);
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
    }
}
