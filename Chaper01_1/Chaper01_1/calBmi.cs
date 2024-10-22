using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaper01_1
{
    class calBmi
    {
        static void Main(string[] args)
        {
            double weight;
            double heightCm;
            double heightM;
            double bmi;

            Console.Write("Please enter your weight (Kg.) : ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter your weight (Cm.) : ");
            heightCm = Convert.ToDouble(Console.ReadLine());

            heightM = heightCm / 100.0f;
            bmi = Math.Round(weight / Math.Pow(heightM, 2), 1);
            if (bmi > 30.0)
            {
                Console.WriteLine("Weight = {0} Kg. , Height = {1} , Bmi = {2} , You are Obese", weight, heightCm, bmi);
            }
            else if (bmi >= 25.0)
            {
                Console.WriteLine("Weight = {0} Kg. , Height = {1} , Bmi = {2} , You are Overweight", weight, heightCm, bmi);
            }            
            else if (bmi >= 18.5)
            {
                Console.WriteLine("Weight = {0} Kg. , Height = {1} , Bmi = {2} , You are Normal weight", weight, heightCm, bmi);
            }
            else if (bmi < 18.5)
            {
                Console.WriteLine("Weight = {0} Kg. , Height = {1} , Bmi = {2} , You are Uderweight", weight, heightCm, bmi);
            }
            else
            {
                Console.WriteLine("Wrong operation");
            }
        }
    }
}
