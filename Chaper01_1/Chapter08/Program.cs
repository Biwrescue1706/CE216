using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Chapter08
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage water = new Beverage("water", 10, 50);
            Beverage estcola = new Beverage("estcola", 13, 45);
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.AddBeverage(water);
            vendingMachine.AddBeverage(estcola);
            Console.WriteLine("NAME\t\tPRICE\t\tAMOUNT");
            vendingMachine.ShowDetail();
            vendingMachine.EditPrice(15, "estcola");
            vendingMachine.ShowDetail();
            vendingMachine.Buy(20,"estcola");
            vendingMachine.ShowDetail();
            vendingMachine.AddBeverage(5, "water");
            vendingMachine.ShowDetail();
            vendingMachine.Buy(5, "water");
            vendingMachine.ShowDetail();
            vendingMachine.Buy(10, "water");
            vendingMachine.ShowDetail();
        }

    }


    //    static void Main(string[] args)
    //    {
    //        string filename = "C:\\Users\\acer\\Desktop\\CE216\\Chapter08\\CustomerData.txt";
    //        ReadFile(fileName);
    //        List<string> texts = new List<string>();
    //        texts.Add("Suppawit Mongkonsuk");
    //        texts.Add("Yuparat Plangklang");
    //        WriteFile(fileName, texts);
    //        ReadFileSt(filename);
    //        List<string> texts = new List<string>();
    //        StreamReader sr = new StreamReader(filename);
    //        string line = sr.ReadToEnd();
    //        while (line != null)
    //        {
    //            texts.Add(line);
    //            line = sr.ReadLine();
    //        }
    //        sr.Close();
    //        texts.Add("phuwanat phahala");
    //        texts.Add("Sanphit Changtrakut");
    //        texts.Add("Saravut Hungsakunrat");
    //        WriteFile(filename, texts);

    //    FileManagement file = new FileManagement(filename);
    //        List<Customer> customers = new List<Customer>();


    //                foreach (string i in file.ReadFile())
    //                {
    //                    if (i != "" )
    //                    {
    //                        string[] data = new string[3];
    //        data = i.Split(',');
    //                        string name = data[0];
    //        string surname = data[1];
    //        int level = Convert.ToInt32(data[2]);
    //        Customer customer = new Customer(name, surname, level);
    //        customers.Add(customer);
    //                    }
    //                }

    //                foreach (Customer s in customers)
    //    {
    //        Console.WriteLine($"FullName : {s.GetFullName()}");
    //        Console.WriteLine($"Level : {s.GetLevel()}");
    //        Console.WriteLine("-------------------------------");
    //    }
    //    Customer cutomers1 = new Customer("Moltha", "Sansa-ard", 1);
    //    List<Customer> customers1 = new List<Customer>();
    //    foreach (string i in file.ReadFile())
    //    {
    //        if (i != "")
    //        {
    //            string[] data = new string[3];
    //            data = i.Split(',');
    //            string name = data[0];
    //            string surname = data[1];
    //            int level = Convert.ToInt32(data[2]);
    //            Customer customer = new Customer(name, surname, level);
    //            customers1.Add(customer);
    //        }
    //    }
    //    customers1.Add(cutomers1);
    //    List<string> content = new List<string>();
    //    foreach (Customer g in customers1)
    //    {
    //        string temp = g.GetName() + "," + g.GetSurName() + "," + g.GetLevel();
    //        content.Add(temp);
    //    }
    //    file.WriteFile(content);
    //            }

    //void ReadFile(object fileName)
    //{
    //    throw new NotImplementedException();
    //}

    //    public static void ReadFile(string filename)
    //    {
    //        try
    //        {
    //            if (File.Exists(filename))
    //            {
    //                string[] fileContent = File.ReadAllLines(filename);
    //                for (int i = 0; i < fileContent.Length; i++)
    //                {
    //                    Console.WriteLine(fileContent[i]);
    //                }
    //            }
    //            else
    //            {
    //                File.Create(filename);
    //            }
    //        }
    //        catch (IOException e)
    //        {
    //            Console.WriteLine(e.Message);
    //        }
    //    }
    //    public static void WriteFile(string filename, List<string> texts)
    //    {
    //        try
    //        {
    //            File.WriteAllLines(filename, texts);
    //            Console.WriteLine("Done.");
    //        }
    //        catch (IOException e)
    //        {
    //            Console.WriteLine(e.Message);
    //        }
    //    }
    //    public static void ReadFileSt(string filename)
    //    {
    //        try
    //        {
    //            StreamReader sr = new StreamReader(filename);
    //            string line = sr.ReadLine();
    //            while (line != null)
    //            {
    //                Console.WriteLine(line);
    //                line = sr.ReadLine();
    //            }
    //            sr.Close();
    //        }
    //        catch (FieldAccessException)
    //        {
    //            Console.WriteLine("File not Found ");
    //            File.Create(filename);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex);
    //        }
    //    }
    //    public static void WriteFileSt(string filename, List<string> texts)
    //    {
    //        StreamWriter sw = new StreamWriter(filename);
    //    }
}