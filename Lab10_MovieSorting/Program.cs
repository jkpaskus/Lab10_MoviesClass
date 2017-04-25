using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_MovieSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies[] ListOfMovies = new Movies[10];

            ListOfMovies[0] = new Movies("Inception", "scifi");
            ListOfMovies[1] = new Movies("Scarface", "drama");
            ListOfMovies[2] = new Movies("Moana", "animated");
            ListOfMovies[3] = new Movies("Secret Life of Pets", "animated");
            ListOfMovies[4] = new Movies("Alien", "horror");
            ListOfMovies[5] = new Movies("Cujo", "horror");
            ListOfMovies[6] = new Movies("Carrie", "horror");
            ListOfMovies[7] = new Movies("Saving Private Ryan", "drama");
            ListOfMovies[8] = new Movies("Avatar", "scifi");
            ListOfMovies[9] = new Movies("Despicable Me", "animated");

            bool loop = true;

            Console.WriteLine("welcome to the Movie List Application!\n");

            //Composition...entering values for movies, and cetegories
            //for (int i = 0; i < ListOfMovies.Length; i++)
            //{
            //    if (ListOfMovies[i] != null)
            //        Console.WriteLine($"\t{ListOfMovies[i].MovieCategory}\n\n\n");
            //}
            while (loop)
            {
                Console.Write("Please enter a category to search by: ");
                string requestCategory = Console.ReadLine();
                Console.WriteLine($"You requested to search for {requestCategory} movies!!!");

                foreach (Movies movie in ListOfMovies)
                {
                    if (requestCategory == movie.MovieCategory)
                    {
                        Console.WriteLine($"This movie: {movie.MovieTitle}");
                    }
                    //else
                    //{
                    //    Console.WriteLine("Nope, TRY AGAIN!");
                    //}
                }

                if (!ContinueApp())
                    loop = false;
            }
        }

        public static bool ContinueApp()
        {
            while (true)
            {
                Console.Write("Do you want to continue? (y/n): ");

                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    //Console.WriteLine();
                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Input not y or n. \n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}

