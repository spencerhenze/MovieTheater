using System;
using System.Collections.Generic;

namespace movietheater
{
    public class Theater
    {
        public string Name;
        public List<Movie> Movies = new List<Movie>();
        public List<Food> FoodList = new List<Food>();

        public Theater(string name)
        {
            Name = name;
        }

        public void addMovie(Movie movie)
        {
            Movies.Add(movie);
        }
        public void addFood(Food food)
        {
            FoodList.Add(food);
        }
    }
}