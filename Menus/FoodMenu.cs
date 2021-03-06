using System;
using System.Collections.Generic;

namespace movietheater
{
    public class FoodMenu
    {
        public bool runFood = true;
        Theater CurrentTheater;
        List<IPurchasable> purchasedFoods = new List<IPurchasable>();


        public FoodMenu(Theater theater)
        {
            CurrentTheater = theater;
        }
        public List<IPurchasable> Run()
        {
            do
            {
                int UserChoice;
                Console.Clear();
                System.Console.WriteLine("Food Menu\n");

                for (int i = 0; i < CurrentTheater.FoodList.Count; i++)
                {
                    Food CurrentFood = CurrentTheater.FoodList[i];
                    CurrentFood.ListPosition = i + 1;
                    Console.WriteLine($"{CurrentFood.ListPosition}. {CurrentFood.Name}  -  ${CurrentFood.Cost}");
                }

                System.Console.WriteLine("\nPlease select a food to purchase it\n");

                if (Int32.TryParse(Console.ReadLine(), out UserChoice))
                {
                    for (int i = 0; i < CurrentTheater.FoodList.Count; i++)
                    {
                        if (CurrentTheater.FoodList[i].ListPosition == UserChoice)
                        {
                            int Quantity;
                            Food SelectedFood = CurrentTheater.FoodList[i];
                            System.Console.WriteLine($"\nHow many {SelectedFood.Name}(s) would you like?\n");
                            if (Int32.TryParse(Console.ReadLine(), out Quantity))
                            {
                                if (SelectedFood.Purchase(Quantity))
                                {
                                    SelectedFood.Quantity = Quantity;
                                    purchasedFoods.Add((IPurchasable)SelectedFood);
                                }
                                System.Console.WriteLine("\nPress ENTER to continue");
                                Console.ReadLine();
                                runFood = false;
                            }
                            else
                            {
                                System.Console.WriteLine("Enter a number. Try again");
                            }
                        }
                    }
                    // User has now selected a valid movie

                }
                else
                {
                    System.Console.WriteLine("Please make a valid selection");
                }


            } while (runFood);

            return purchasedFoods;


        }
    }
}