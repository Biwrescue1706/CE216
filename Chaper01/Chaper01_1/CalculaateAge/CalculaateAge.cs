using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaateAge
{
    internal class CalculaateAge
    {
        static void Main(string[] args)
        {
            DateTime bithdate;
            int age;

            Console.Write("please enter your birtdate : ");
            bithdate = Convert.ToDateTime(Console.ReadLine());

            int year;
            year = bithdate.Year;
            Console.WriteLine(year);

            int yearNow; /*ปีปัจจุบัน*/
            yearNow = DateTime.Now.Year;
            Console.WriteLine(yearNow);

            age = yearNow - year;
            Console.WriteLine("This year is {0} , youwas born in {1} , you are age : {2} year ", yearNow, year, age);
        }
    }
}
