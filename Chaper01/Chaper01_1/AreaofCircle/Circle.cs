using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaofCircle
{
    class Circle
    {
        static void Main (string[] args)
        {
            double radius;
            double circumference;
            double area;

            Console.Write("Please enter radius : "); //ใส่รัศมีวงกลม
            radius = Convert.ToSingle(Console.ReadLine());

            circumference = 2 * Math.PI * radius;//คำนวนเส้นรอบวง
            area = Math.PI * Math.Pow(radius, 2);//คำนวนพื้นที่วงกลม

            Console.WriteLine("Circumference of Circle = ", Math.Round(circumference,2));
            Console.WriteLine("Area of Circle = {0:n2", Math.Round(area,2));
        }
    }
}
