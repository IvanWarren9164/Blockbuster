using System;
using System.Collections.Generic;
using System.IO;


namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {

            Blockbuster blockbuster = new Blockbuster();

            blockbuster.Movies.Add(new DVD("Test Movie 1", Genre.Drama, 100));
            blockbuster.Movies.Add(new DVD("Test Movie 2", Genre.Comedy, 110));
            blockbuster.Movies.Add(new DVD("Test Movie 3", Genre.Horror, 130));
            blockbuster.Movies.Add(new VHS("Test Movie 4", Genre.Romance, 140));
            blockbuster.Movies.Add(new VHS("Test Movie 5", Genre.Action, 150));
            blockbuster.Movies.Add(new VHS("Test Movie 6", Genre.Romance, 160));


            foreach (Movie movie in blockbuster.Movies)
            {
                movie.Scenes.Add("Scene 1");
                movie.Scenes.Add("Scene 2");
                movie.Scenes.Add("Scene 3");
                movie.Scenes.Add("Scene 4");
            }


            //blockbuster.Movies[1].Play();
            //blockbuster.Movies[4].Play();
            //blockbuster.Movies[1].PlayWholeMovie();
            //blockbuster.Movies[4].PlayWholeMovie();
            //blockbuster.CheckOut(blockbuster.Movies);
            //blockbuster.PrintMovies(blockbuster.Movies);
            //blockbuster.CheckOut(blockbuster.Movies);

        }
    }
}
