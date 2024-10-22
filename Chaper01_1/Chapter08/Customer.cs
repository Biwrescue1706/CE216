using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter08
{
    class Customer
    {
        private string name;
        private string surname;
        private int level;
        public Customer(string name, string surname, int level)
        {
            this.name = name;
            this.surname = surname;
            this.level = level;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetSurName(string surname) 
        {
            this.surname = surname;
        }
        public string GetSurName()
        {
            return this.surname;
        }
        public void SetLevel(int level)
        {
            this.level = level;
        }
        public String GetFullName()
        {
                return this.name+" "+surname;
        }
        public int GetLevel()
        {
            return level;
        }
    }
}
