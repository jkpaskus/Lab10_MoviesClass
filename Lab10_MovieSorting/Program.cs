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

            ListOfMovies[0] = new Movies("Inception", "Scifi");
            ListOfMovies[1] = new Movies("Scarface", "Drama");
            ListOfMovies[2] = new Movies("Moana", "Animated");
            ListOfMovies[3] = new Movies("Secret Life of Pets", "Animated");
            ListOfMovies[4] = new Movies("Alien", "Horror");
            ListOfMovies[5] = new Movies("Cujo", "Horror");
            ListOfMovies[6] = new Movies("Carrie", "Horror");
            ListOfMovies[7] = new Movies("Saving Private Ryan", "Drama");
            ListOfMovies[8] = new Movies("Avatar", "Scifi");
            ListOfMovies[9] = new Movies("Despicable Me", "Animated");

            //Composition...entering values for movies, and cetegories
            //for (int i = 0; i < ListOfMovies.Length; i++)
            //{
            //    if (ListOfMovies[i] != null)
            //        Console.WriteLine($"\t{ListOfMovies[i].MovieCategory}\n\n\n");
            //}

            Console.Write("Please enter a category to search by: ");
            string requestCategory = Console.ReadLine();
            Console.WriteLine ($"You requested to search for {requestCategory} movies!!!");

            foreach (Movies movie in ListOfMovies)
            {
                if ( requestCategory == movie.MovieCategory )
                {
                    Console.WriteLine($"This movie: {movie.MovieTitle}");
                }
                //else
                //{
                //    Console.WriteLine("Nope, TRY AGAIN!");
                //}
            }
        }
    }
    }

