using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_02
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Random rand = new Random();
        //    List<BankAccount> accounts = new List<BankAccount>();
        //    List<Customer> customers = new List<Customer>();
            
           
        //    string fullNameCus1 = "Phuwanat Phahala";
        //    string telnumbercus1 = "061-174-7731";
        //    string accNumer1 = rand.Next(101,1000).ToString()+""+ telnumbercus1;
        //    BankAccount bankAccount1 = new BankAccount(accNumer1, 20000);
        //    bankAccount1.AccountName = fullNameCus1;
        //    string fullNameCus2 = "Saravut Hongsakunrat";
        //    string telnumbercus2 = "061-585-5695";
        //    string accNumer2 = rand.Next(101, 1000).ToString() + "" + telnumbercus2;
        //    BankAccount bankAccount2 = new BankAccount(accNumer2, 100000);
        //    bankAccount2.AccountName = fullNameCus2;
        //    string fullNameCus3 = "Sanphic Chantrakut";
        //    string telnumbercus3 = "096-556-5822";
        //    string accNumer3 = rand.Next(101, 1000).ToString() + "" + telnumbercus1;
        //    BankAccount bankAccount3 = new BankAccount(accNumer3, 1500);
        //    bankAccount3.AccountName = fullNameCus3;

        //    Customer customer1 = new Customer(fullNameCus1,telnumbercus1,bankAccount1);
        //    Customer customer2 = new Customer(fullNameCus2,telnumbercus2,bankAccount2);
        //    Customer customer3 = new Customer(fullNameCus3,telnumbercus3,bankAccount3);

        //    customers.Add(customer1);
        //    customers.Add(customer2);
        //    customers.Add(customer3);

        //    foreach (Customer i in customers)
        //    {
        //        Console.WriteLine("Fullname : {0}", i.Fullname);
        //        Console.WriteLine("TelNumber : {0}", i.TelNumber);
        //        Console.WriteLine("AccountNumber : {0}", i.Bank.AccountNumber);
        //        Console.WriteLine("AccountName : {0}", i.Bank.AccountName);
        //        Console.WriteLine("Balance : {0}", i.Bank.Balance);
        //        Console.WriteLine("================");
        //    }

        //    Console.WriteLine("=======After Deposit=========");
        //    bool isDiposit1 = bankAccount1.Deposit(500);
        //    foreach (Customer i in customers)
        //    {
        //        Console.WriteLine("Fullname : {0}", i.Fullname);
        //        Console.WriteLine("TelNumber : {0}", i.TelNumber);
        //        Console.WriteLine("AccountNumber : {0}", i.Bank.AccountNumber);
        //        Console.WriteLine("AccountName : {0}", i.Bank.AccountName);
        //        Console.WriteLine("Balance : {0}", i.Bank.Balance);
        //        Console.WriteLine("================");
        //    }

        //    Console.WriteLine("=======After Withdraw=========");
        //    bool isWithdraw1 = bankAccount1.Withdraw(10000);
        //    foreach (Customer i in customers)
        //    {
        //        Console.WriteLine("Fullname : {0}", i.Fullname);
        //        Console.WriteLine("TelNumber : {0}", i.TelNumber);
        //        Console.WriteLine("AccountNumber : {0}", i.Bank.AccountNumber);
        //        Console.WriteLine("AccountName : {0}", i.Bank.AccountName);
        //        Console.WriteLine("Balance : {0}", i.Bank.Balance);
        //        Console.WriteLine("================");
        //    }

        //    Console.WriteLine("=======After Withdraw=========");
        //    bool isWithdraw2 = bankAccount1.Withdraw(1000);
        //    foreach (Customer i in customers)
        //    {
        //        Console.WriteLine("Fullname : {0}", i.Fullname);
        //        Console.WriteLine("TelNumber : {0}", i.TelNumber);
        //        Console.WriteLine("AccountNumber : {0}", i.Bank.AccountNumber);
        //        Console.WriteLine("AccountName : {0}", i.Bank.AccountName);
        //        Console.WriteLine("Balance : {0}", i.Bank.Balance);
        //        Console.WriteLine("================");
        //    }

        //    Console.WriteLine("=======After Transfer=========");
        //    bool isTransfer1 = bankAccount1.Transfer(bankAccount2, 400);
        //    foreach (Customer i in customers)
        //    {
        //        Console.WriteLine("Fullname : {0}", i.Fullname);
        //        Console.WriteLine("TelNumber : {0}", i.TelNumber);
        //        Console.WriteLine("AccountNumber : {0}", i.Bank.AccountNumber);
        //        Console.WriteLine("AccountName : {0}", i.Bank.AccountName);
        //        Console.WriteLine("Balance : {0}", i.Bank.Balance);
        //        Console.WriteLine("================");
        //    }

        //    Console.WriteLine("=======After CalInterest=========");
        //    bool isCalInterest1 = bankAccount1.Callinterest();
        //    foreach (Customer i in customers)
        //    {
        //        Console.WriteLine("Fullname : {0}", i.Fullname);
        //        Console.WriteLine("TelNumber : {0}", i.TelNumber);
        //        Console.WriteLine("AccountNumber : {0}", i.Bank.AccountNumber);
        //        Console.WriteLine("AccountName : {0}", i.Bank.AccountName);
        //        Console.WriteLine("Balance : {0}", i.Bank.Balance);
        //        Console.WriteLine("================");
        //    }
        //}
    }
}
