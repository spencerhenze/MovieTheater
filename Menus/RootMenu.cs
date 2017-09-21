using System;
using System.Collections.Generic;

namespace movietheater
{
    public class RootMenu
    {
        public bool run = true;
        Theater CurrentTheater;
        Cart ShoppingCart = new Cart();


        public RootMenu(Theater theater)
        {
            CurrentTheater = theater;
        }

        public void Run()
        {
            do
            {
                int Choice;
                Console.Clear();
                Console.WriteLine("Please choose an option:\n1. Buy Tickets\n2. Buy Food");

                if (Int32.TryParse(Console.ReadLine(), out Choice))
                {
                    switch (Choice)
                    {
                        case 1:
                            MovieMenu MovMenu = new MovieMenu(CurrentTheater);
                            MovMenu.Run();
                            // TODO: add cart functionality to Movies
                            break;
                        case 2:
                            FoodMenu FoodMenu = new FoodMenu(CurrentTheater);
                            ShoppingCart.Items.AddRange(FoodMenu.Run());
                            DisplayCart();
                            break;
                        default:
                            System.Console.WriteLine("Please make a valid choice.");
                            continue;
                    }
                }


            } while (run);
        }

        public void DisplayCart()
        {
            System.Console.WriteLine($"Item:                      Cost:                      Quantity:\n");
            foreach (var item in ShoppingCart.Items)
            {
                System.Console.WriteLine($"{item.Name}                      ${item.Cost}                      {item.Quantity}");
            }
            Console.ReadLine();

        }
    }
}