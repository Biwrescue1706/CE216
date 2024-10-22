using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    class Person
    {
        private double height;//ส่วนสูง
        private double weight;//น้ำหนัก
        private int age; //อายุ
        private int sex; //เพศ

        public Person() 
        {
            height = 163;
            weight = 106;
            age = 21;
            sex = 1;
        }
        public Person(double height, double weight, int age , int sex)
        {
            this.height = height;
            this.weight = weight;
            this.age = age;
            this.sex = sex;
        }
        public string CalBmi()
        {
            double bmi = weight /Math.Pow(ConvertCToM(),2);
            if (bmi > 30.0)
            {
                return "Obese";
            }
            else if (bmi >= 25.0)
            {
                return "Overweight";
            }
            else if(bmi >= 18.5)
            {
                return "Normal weight";
            }
            else
            {
                return "Underweight";
            }
        }
        public double CalBmr()
        {
            if (sex == 1) //Male เพศชาย
            {
                return Math.Round(66.47 + (13.75 * weight) + (5.003*height) - (6.755*age),2);
            }
            else //Female
            {
                return Math.Round(665.1 + (9.563 * weight) + (1.850 * height) - (4.676 * age),2);
                
            }
        }
        private double ConvertCToM()
        {
            return height / 100.0f;
        }

    }
}
