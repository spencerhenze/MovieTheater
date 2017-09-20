using System;
using System.Collections.Generic;

namespace movietheater
{
    public class ShowtimeMenu
    {
        public bool runST = true;
        Theater CurrentTheater;
        Movie CurrentMovie;


        public ShowtimeMenu(Theater theater, Movie movie)
        {
            CurrentTheater = theater;
            CurrentMovie = movie;
        }

        public void Run()
        {
            do
            {
                int UserChoice;
                Console.Clear();
                System.Console.WriteLine($"Showtime menu for {CurrentMovie.Title}");

                int dictIndex = 1;
                Dictionary<int, Ticket> listItems = new Dictionary<int, Ticket>(); // string will be the time and the ticket will have all of the other data including purchasable

                foreach(KeyValuePair<string, Ticket> showtime in CurrentMovie.Showtimes)
                {
                    listItems.Add(dictIndex, showtime.Value);
                    Console.WriteLine($"{dictIndex}. {showtime.Key}");
                    dictIndex++;
                }
                dictIndex = 1;


                System.Console.WriteLine("Please enter a showtime to purchase it\n");

                if (Int32.TryParse(Console.ReadLine(), out UserChoice))
                {
                    // User has now selected a valid movie
                    foreach(KeyValuePair<int, Ticket> showtime in listItems)
                    {
                        if(showtime.Key == UserChoice)
                        {
                            int Quantity;
                            System.Console.WriteLine($"How many tickets would you like? (There are/is {showtime.Value.Inventory} remaining.");
                            if(Int32.TryParse(Console.ReadLine(), out Quantity))
                            {
                                if(showtime.Value.Purchase(Quantity))
                                {
                                    System.Console.WriteLine("Press ENTER to continue");
                                    Console.ReadLine();
                                    return;
                                }
                            }
                        }
                    }

                }
                else
                {
                    System.Console.WriteLine("Please make a valid selection");
                }


            } while (runST);

        }

    }
}