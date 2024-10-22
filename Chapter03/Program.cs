using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.Write("Please enter the course id : ");
            string courseId = Console.ReadLine(); //Input courseId
            Console.Write("Please enter course name : ");
            string courseName = Console.ReadLine();//Input courseName
            Console.Write("Please enter a number of student for adding into course : ");
            int limitStu = Convert.ToInt32(Console.ReadLine());//Input limitStu of course

            //Create Object of Class Teacher 2 Object

            Teacher teacher1 = new Teacher("500522", "Nutchanrt", "Satvinij");
            Teacher teacher2 = new Teacher("520601", "Narongdech", "Keeratipranont");

            //Create Object of Class Student 5 Object

            Student student1 = new Student("66110045" , "Phuwanat" , "Phahala" , 2.58);
            Student student2 = new Student("66111310", "Saravut", "Hungsakunrat", 3.9);
            Student student3 = new Student("66111384", "Sanphit", "Chantrakut", 3.0);
            Student student4 = new Student("66112331", "Suppawit", "Mongkonsuk", 3.5);
            Student student5 = new Student("66112238", "Yuparat", "plangklang", 3.5);

            Course course = new Course(courseId, courseName, teacher1, limitStu);

            course.Register(student1);
            course.Register(student2);
            course.Register(student3);
            //Add student to the arrey

            course.SetTeacher(teacher1);

            course.PrintCourseDetail();
            course.GetTeacherFullName();
            course.GetStudentFullName();
        }
    }
}
