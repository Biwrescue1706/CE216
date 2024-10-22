using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08
{
    class VendingMachine
    {
        private List<Beverage> beverages;

        // Constructor
        public VendingMachine()
        {
            beverages = new List<Beverage>();
        }

        // Method to display all beverages in the vending machine
        public void ShowDetail()
        {
            Console.WriteLine("List of beverages in the vending machine:");
            foreach (Beverage beverage in beverages)
            {
                beverage.DisplayInfo();
            }
        }

        // Method to add a new beverage to the vending machine
        public void AddBeverage(Beverage newBeverage)
        {
            beverages.Add(newBeverage);
        }

        // Method to set a new price for a beverage
        public void EditPrice(double newPrice, string beverageName)
        {
            foreach (Beverage beverage in beverages)
            {
                if (beverage.GetName() == beverageName)
                {
                    beverage.SetPrice(newPrice);
                    Console.WriteLine($"Price of {beverageName} has been updated to {newPrice}");
                    return;
                }
            }
            Console.WriteLine($"Beverage '{beverageName}' not found.");
        }

        // Method to add quantity of a beverage
        public void AddBeverage(int quantity, string beverageName)
        {
            foreach (Beverage beverage in beverages)
            {
                if (beverage.GetName() == beverageName)
                {
                    beverage.AddQuantity(quantity);
                    Console.WriteLine($"{quantity} {beverageName}(s) added to the vending machine.");
                    return;
                }
            }
            Console.WriteLine($"Beverage '{beverageName}' not found.");
        }

        // Method to sell a beverage
        public void Buy(double payment, string beverageName)
        {
            foreach (Beverage beverage in beverages)
            {
                if (beverage.GetName() == beverageName)
                {
                    beverage.Sell(payment);
                    return;
                }
            }
            Console.WriteLine($"Beverage '{beverageName}' not found.");
        }
    }
}
