using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09
{
    class Person
    {
        private string fullname;
        private string telNo;
        private DateTime dateOfBirth;
        private int age;
        private string image;

        public Person(string fullname, string telNo, string dateOfBirth)
        {
            this.fullname = fullname;
            this.telNo = telNo;
        }

        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }
        public string TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        public int Age
        {
            get { return DateTime.Today.Year - dateOfBirth.Year; }
            set { age = value; }
        }
        public string DateOfBirthSt
        {
            get { return dateOfBirth.ToLongDateString(); }
        }
        public string SetData()
        {
            return fullname + "," + telNo + "," + dateOfBirth.ToShortDateString();
        }
    }
}
