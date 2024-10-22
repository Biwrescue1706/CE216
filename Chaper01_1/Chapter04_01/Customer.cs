using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_01
{
    class Customer
    {
        private string memberid;
        private string name;
        private string surname;
        private string custell;
        private string membershipLevel;

        public Customer(string id , string name , string surname , string membershipLevel )
        {
            memberid = id;
            this.name = name;
            this.surname = surname;
            this.membershipLevel = membershipLevel;
        }
        public string GetFullName()
        {
            return $"{name} {surname}";
        }
        public string GetId()
        {
            return memberid;
        }
    }
}
