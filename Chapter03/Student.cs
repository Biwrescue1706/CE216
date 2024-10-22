using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class Student
    {
        private string stuId;
        private string stuName;
        private string stuSurname;
        private double gpa;

        public Student(string id , string name , string surname, double gpa) 
        {
            stuId = id;
            stuName = name;
            stuSurname = surname;
            this.gpa = gpa;
        }

        public void SetStuId(string id)
        {
            stuId = id;
        }
        public string GetStuId()
        {
            return stuId;
        }
      
        public void SetStuName(string name)
        {
            stuName = name;
        }

        public string GetStuName()
        {
            return stuName;
        }
        public void SetStuSurName(string surname)
        {
            stuSurname = surname;
        }
        public string GetStuSurname()
        {
            return stuSurname;
        }
        public void SetGpa (double gpa)
        {
            this.gpa = gpa;
        }
        public double GetGpa()
        {
            return gpa;
        }
        public void PrintStuDetails()
        {
            Console.Write($"Student ID : {stuId} \nStudent Name : {stuName} {stuSurname} \nGpa :{gpa}");
        }
    }
}
