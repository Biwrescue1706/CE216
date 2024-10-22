using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class Course
    {
        private string courseId;
        private string courseName;
        private Teacher teacher;
        private Student[] students;
        private int studentCount = 0;

        public Course(string id, string name, Teacher teacher, int limitStu)
        {
            this.courseId = id;
            this.courseName = name;
            this.teacher = teacher;
            this.students = new Student[limitStu];
        }
        public void Register(Student student)
        {
            students[studentCount] = student;
            studentCount++;
        }

        public void DisplayDetail()//Show Name Student 
        {
            for (int i = 0; i < studentCount; i++)
            {
                students[i].PrintStuDetails();
            }
        }
        public Course(int limitstu)
        {
            students = new Student[limitstu];
        }
        public void SetcourseId(string courseId)
        {
            this.courseId = courseId;
        }
        public string GetCourseId()
        {
            return this.courseId;
        }

        public void SetcourseName(string courseName)
        {
            this.courseName = courseName;
        }
        public string GetCourseName()
        {
            return this.courseName;
        }
        //====================================================//
        
        public void SetTeacher(Teacher teacher)
        {
            this.teacher = teacher;
        }
        public void GetTeacherFullName()
        {
            string TeacherFullName = $"{teacher.GetTName()} {teacher.GetTSurname()}";
            Console.WriteLine($"Teacher : {TeacherFullName} \nThis Course Has {studentCount} student");
            //Show FullName Teacher and studentCount
        }
        public void PrintCourseDetail()
        {
            Console.WriteLine($"Course Detail : {courseId} {courseName}"); // Show courseId courseName
        }
        public void GetStudentFullName()
        {
            for (int i = 0; i < studentCount; i++)
            {
                if (students[i] != null)
                { 
                    Console.WriteLine("==================================================");
                    string stuId = students[i].GetStuId();
                    string stdName = students[i].GetStuName();
                    string stuSurname = students[i].GetStuSurname();
                    Console.WriteLine($"{i+1}.{stuId} {stdName} {stuSurname}");//Show ID And FullName
                }
                
            }
             Console.WriteLine("==================================================");
        }
    }
}
