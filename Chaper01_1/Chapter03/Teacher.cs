using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class Teacher
    {
        private string tId;
        private string tName;
        private string tSurname;

        public Teacher(string id , string name , string surname) 
        {
            tId = id;
            tName = name;
            tSurname = surname;
        }
        public void SetTId(string id)
        {
            tId = id;
        }
        public string GetTId()
        {
            return tId;
        }
        public void SetTName(string name)
        {
            tName = name;
        }
        public string GetTName()
        {
            return tName;
        }
        public void SetTSurname(string surname)
        {
            tSurname = surname;
        }
        public string GetTSurname()
        {
            return tSurname;
        }
        public void PrintTDetails()
        {
            Console.Write($"Teacher ID : {tId} \nTeacher Name : {tName} {tSurname}");
        }
    }
}
