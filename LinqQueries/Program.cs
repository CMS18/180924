using LinqQueries.MyLinq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
            {
                new Movie { Title="The Dark Knight", Rating=8.9f, Year = 2008 },
                new Movie { Title="Star Wars V", Rating = 8.7f, Year = 1980 },
                new Movie { Title ="Casablanca", Rating=8.5f, Year = 1942 },
                new Movie { Title = "The King's Speech", Rating = 8.0f, Year = 2010 }
            };


            // LINQ - Query Syntax
            var query = from movie in movies
                        where movie.Year > 2000
                        select movie;

            /*
             * 
             * 
                        orderby movie.Rating descending
                        select movie; */
            // LINQ - Method Syntax
            var query2 = movies.Where(movie => movie.Year > 2000)
                        .OrderByDescending(movie => movie.Rating)
                        .Select(movie => movie)
                        .ToList();


            var query3 = movies.MyFilter(movie => movie.Year > 2000);

            Console.WriteLine($"Count: {query2.Count()}");

            foreach (var movie in query2)
            {
                Console.WriteLine($"{movie.Title,-30} : {movie.Rating}");
            }

        }
    }
}
