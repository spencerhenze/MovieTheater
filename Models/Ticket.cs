using System;
using System.Collections.Generic;

namespace movietheater
{
    public class Ticket : IPurchasable
    {
        Movie Movie;

        string Time;

        public Ticket(Movie movie, string time, float cost, int inventory)
        {
            Movie = movie;
            Time = time;
            Cost = cost;
            Inventory = inventory;
        }

        public float Cost { get; set; }
        public int Inventory { get; set; }

        public bool Purchase(int quantity)
        {
            if (Inventory - quantity >= 0)
            {
                Inventory -= quantity;
                System.Console.WriteLine($"Here is your ticket(s)");
                return true;
            }
            System.Console.WriteLine($"\nSorry, but we only have {(Inventory == 0? "none" : Inventory.ToString())} left");
            return false;
        }
    }
}