using System;
using System.Collections.Generic;

namespace movietheater
{
    public class MovieMenu
    {
        public bool runMM = true;
        Theater CurrentTheater;

        public MovieMenu(Theater theater)
        {
            CurrentTheater = theater;
        }

        public void Run()
        {
            do
            {
                int UserChoice;
                Console.Clear();
                System.Console.WriteLine("Movie Ticket Menu\n");

                for (int i = 0; i < CurrentTheater.Movies.Count; i++)
                {
                    Movie CurrentMovie = CurrentTheater.Movies[i];
                    CurrentMovie.ListPosition = i + 1;
                    Console.WriteLine($"{CurrentMovie.ListPosition}. {CurrentMovie.Title}");
                }

                System.Console.WriteLine("Please select a movie to see its showtimes\n");

                if (Int32.TryParse(Console.ReadLine(), out UserChoice))
                {
                    for (int i = 0; i < CurrentTheater.Movies.Count; i++)
                    {
                        if (CurrentTheater.Movies[i].ListPosition == UserChoice)
                        {
                            ShowtimeMenu TheseShowings = new ShowtimeMenu(CurrentTheater, CurrentTheater.Movies[i]);
                            TheseShowings.Run();
                        }
                    }
                    // User has now selected a valid movie

                }
                else
                {
                    System.Console.WriteLine("Please make a valid selection");
                }


            } while (runMM);

        }

    }
}