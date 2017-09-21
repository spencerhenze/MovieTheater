using System;
using System.Collections.Generic;

namespace movietheater
{
    public class Food : IPurchasable
    {
        public string Name { get; set; }
        public float Cost { get; set; }
        public int Inventory { get; set; }
        public int Quantity { get; set; }
        public int ListPosition = 0;


        public Food(string name, float cost, int inventory)
        {
            Name = name;
            Cost = cost;
            Inventory = inventory;
        }

        public bool Purchase(int quantity)
        {
            if (Inventory - quantity >= 0)
            {
                Inventory -= quantity;
                System.Console.WriteLine($"\nYour total is: ${Cost * quantity}");
                System.Console.WriteLine($"Here are(is) your {quantity} {Name}(s)");
                return true;
            }
            System.Console.WriteLine($"\nSorry, but we only have {(Inventory == 0 ? "none" : Inventory.ToString())} left");
            return false;
        }

    }
}