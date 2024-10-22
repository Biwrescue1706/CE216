using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_02
{
    class BankAccount
    {
        private double balance;
        private double interest;
        private double interestRate;
        private string accountNumber;
        private string accountName;

        public BankAccount(string accNumber, double balance)
        {
            this.balance = balance;
            accountNumber = accNumber;
            interestRate = 0.05;
            interest = 0;
            accountName = "";
        }

        public double Balance 
        {
            get { return balance; }
            set { balance = value; }
        }
        public double Interest
        {
            get { return interest; }
            set { interest = value; }
        }
        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }

        public bool Withdraw(double money)
        {
            if (balance >= money)
            {
                balance = balance - money;
                return true;
            }
            return true;
        }
        public bool Deposit(double money)
        {
            this.balance += money;
            return true;
        }
        public bool Transfer(BankAccount destination , double money)
        {
            //bool isDepositOk = false;
            //if (balance >= money )
            //{
            //    balance = balance - money;
            //    isDepositOk = destination.Deposit(money);
            //}
            //else
            //{
            //    return false;
            //}
            bool isOkWithdraw =false;
            bool isOkDeposit =false;
            bool isOkTransfer =false;
            if (isOkWithdraw)
            {
                isOkDeposit = destination.Deposit(money);
                if (isOkDeposit)
                {
                    isOkTransfer = true;
                }
            }
            return isOkTransfer;
        }
        public bool Callinterest()
        {   
            //bool isOk =false;
            interest = balance * interestRate;
            //balance = balance + interest;
            //isOk = Deposit(interest);
            //if (isOk == true)
            //{
            //    return true ;
            //}
            //else
            //{
            //    return false ;
            //}
            if(Deposit(interest))
            {
                return true;
            }
            return false;
        }
    }
}
