using System;
using System.Collections.Generic;

namespace Blockbuster
{
    public class DVD : Movie
    {
        public DVD(string title, Genre category, int runtime)
        {
            Title = title;
            Category = category;
            RunTime = runtime;
        }
        public override void Play()
        {
            int userchoice = 0;

            Console.WriteLine("What scence would you like to watch?: ");
            PrintScenes();
            userchoice = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Scenes[userchoice - 1]}");
        }

        public override void PlayWholeMovie()
        {
            foreach(string scence in Scenes)
            {
                Console.WriteLine($"{scence}");
            }
        }
    }
}
