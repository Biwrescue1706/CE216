using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_02
{
    class Customer
    {
        private string fullname;
        private string telNumber;
        private BankAccount bankAccount;

        public Customer(string fullname, string telNumber, BankAccount bank)
        {
            this.fullname = fullname;
            this.telNumber = telNumber;
            bankAccount = bank;
        }
        public string Fullname
        {
            set { fullname = value; }
            get { return fullname; }
        }
        public string TelNumber
        {
            set { telNumber = value; }
            get { return telNumber; }
        }

        public BankAccount Bank
        {
            get { return bankAccount; }
            set { bankAccount = value; }
        }
        public void PrintDetail()
        {
        }
    }
}
