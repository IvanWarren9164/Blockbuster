using System;
using System.Collections.Generic;

namespace Blockbuster
{
    public class Blockbuster
    {
        public List<Movie> Movies = new List<Movie>();

        

        public void PrintMovies(List<Movie> listofmovies)
        {
            int i = 1;
            foreach(Movie movie in listofmovies)
            {
                Console.WriteLine($"[{i}]{movie.Title}");
                i++;
            }
        }

        public Movie CheckOut(List<Movie> listofmovies)
        {
            int userchoice = 0;
 
            Console.WriteLine("Which movie you want?:");
            PrintMovies(listofmovies);
            userchoice = int.Parse(Console.ReadLine());

            listofmovies[userchoice - 1].PrintInfo();

            return listofmovies[userchoice - 1];
            
        }


    }
}
