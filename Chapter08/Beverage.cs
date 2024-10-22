using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08
{
    class Beverage
    {
        private string name;
        private double price;
        private int quantity;
        private string filePath;

        // Constructor

        public Beverage(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.filePath = $"{name.Replace(" ", "")}.txt";
        }

        // Method to set default values
        public void SetDefault()
        {
            this.price = 0;
            this.quantity = 0;
            SaveToFile();
        }

        // Method to get beverage name
        public string GetName()
        {
            return name;
        }

        // Method to get beverage price
        public double GetPrice()
        {
            return price;
        }

        // Method to get quantity of beverage
        public int GetQuantity()
        {
            return quantity;
        }

        // Method to set new price for beverage
        public void SetPrice(double newPrice)
        {
            this.price = newPrice;
            SaveToFile();
        }

        // Method to add quantity of beverage
        public void AddQuantity(int amount)
        {
            this.quantity += amount;
            SaveToFile();
        }

        // Method to display all information of beverage
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}\tPrice: {price}\tQuantity: {quantity}");
        }

        // Method to sell beverage
        public void Sell(double payment)
        {
            if (payment < price)
            {
                Console.WriteLine("Not enough money.");
            }
            else if (payment > price)
            {
                Console.WriteLine($"Change: {payment - price}");
            }
            else
            {
                Console.WriteLine("Payment exact. Beverage sold.");
                quantity--;
                SaveToFile();
            }
        }

        // Method to read beverage data from text file
        public void ReadFromFile()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    if (lines.Length >= 3)
                    {
                        name = lines[0];
                        price = double.Parse(lines[1]);
                        quantity = int.Parse(lines[2]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"An error occurred while reading file: {e.Message}");
                }
            }
            else
            {
                Console.WriteLine($"File '{filePath}' does not exist.");
            }
        }

        // Method to write beverage data to text file
        public void SaveToFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(name);
                    sw.WriteLine(price);
                    sw.WriteLine(quantity);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while writing file: {e.Message}");
            }
        }
    }
}