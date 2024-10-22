using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper01_2
{
    class calAreaMethod
    {
        static void Main(string[] args)
        {
            int selected;
            Console.WriteLine("Please select area calculation ");
            Console.Write("1.Rectangle \n2.Triangle  \n3.Circle");
            Console.Write("\nPlease select shape to Calculate Area : ");
            selected = Convert.ToInt32(Console.ReadLine());

            switch (selected)
            {
                case 1:
                    CalRectangleleArea();
                    break;
                case 2:
                    CalTriangleArea();
                    break;
                case 3:
                    CalCircleArea();
                    break;
                default:
                    Console.WriteLine("Selected number must be 1-3 ");
                    break;
            }
            static void CalRectangleleArea()
            {
                int width, legth;
                double area;
                Console.Write("\n---------------------------------\n");
                Console.WriteLine("You have selected a Rectangle shape to Calculate Area");
                Console.Write("Please enter legth : ");//ความยาว
                legth = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter width : ");//ความกว้าง
                width = Convert.ToInt32(Console.ReadLine());

                area = legth * width;
                Console.WriteLine($"Area of Rectangle = {area}");
            }
            static void CalTriangleArea()
            {
                int height, baselegth;
                double area;
                Console.Write("\n---------------------------------\n");
                Console.WriteLine("You have selected a Triangle shape to Calculate Area");
                Console.Write("Please enter legth : ");//ค่าความยาวของฐานสามเหลี่ยม
                baselegth = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter height : ");//ความสูงของสามเหลี่ยม
                height = Convert.ToInt32(Console.ReadLine());

                area = 0.5 * baselegth * height;

                Console.WriteLine($"Area of Triangle = {area:n2}");
            }
            static void CalCircleArea()
            {
                int radiues;
                double area;
                Console.Write("\n---------------------------------\n");
                Console.WriteLine("You have selected a Circle shape to Calculate Area");
                Console.Write("Please enter radiues : ");//ค่าฐานของสามเหลี่ยม
                radiues = Convert.ToInt32(Console.ReadLine());

                area = Math.PI * Math.Pow(radiues, 2);

                Console.WriteLine($"Area of Circle = {area:n2}");
            }
        }
    }
}
