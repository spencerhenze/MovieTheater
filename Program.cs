using System;

namespace movietheater
{
    class Program
    {
        static void Main(string[] args)
        {
            Theater Majestic = new Theater("Majestic");
            Console.WriteLine("Hello Movies!");

            //Make Movies
            Movie IT = new Movie("IT", "Clowns are scary");
            Movie WeddingSinger = new Movie("The Wedding Singer", "Adam Sandler haha");
            Movie JurassicPark = new Movie("Jurassic Park", "Dinosaurs are awesome");

            //Make Showtimes
            IT.addShowtime("10:00", 5.99f, 100);
            IT.addShowtime("12:00", 5.99f, 100);
            IT.addShowtime("2:00", 5.99f, 100);

            WeddingSinger.addShowtime("10:00", 5.99f, 100);
            WeddingSinger.addShowtime("12:00", 5.99f, 100);
            WeddingSinger.addShowtime("2:00", 5.99f, 100);

            JurassicPark.addShowtime("10:00", 5.99f, 100);
            JurassicPark.addShowtime("12:00", 5.99f, 100);
            JurassicPark.addShowtime("2:00", 5.99f, 100);



            //Make Food
            Food Nachos = new Food("Nachos", 5.99f, 25);
            Food Popcorn = new Food("Popcorn", 8.50f, 120);
            Food Drink = new Food("Drink", 4.99f, 200);

            //Add the stuff to the theatre
            Majestic.addFood(Nachos);
            Majestic.addFood(Popcorn);
            Majestic.addFood(Drink);

            Majestic.addMovie(IT);
            Majestic.addMovie(WeddingSinger);
            Majestic.addMovie(JurassicPark);

            RootMenu Base = new RootMenu(Majestic);
            Base.Run();

        }
    }
}
