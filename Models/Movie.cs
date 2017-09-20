using System;
using System.Collections.Generic;

namespace movietheater
{
    public class Movie
    {
        public string Title;
        public string Description;

        public int ListPosition = 0;

        public Dictionary<string, Ticket> Showtimes = new Dictionary<string, Ticket>(); // string will be the time and the ticket will have all of the other data including purchasable
        public Movie(string title, string description)
        {
            Title = title;
            Description = description;
        }
        // Showtimes

        public void addShowtime(string time, float cost, int inventory)
        {
            Showtimes.Add(time, new Ticket(this, time, cost, inventory));
        }
    }
}