using System;
using System.Collections.Generic;

namespace Blockbuster
{
    public class VHS : Movie
    {
        public VHS(string title, Genre category, int runtime)
        {
            Title = title;
            Category = category;
            RunTime = runtime;
        }
        public int CurrentTime = 1;

        public override void Play()
        {
            Console.WriteLine($"{Title} ---- {Scenes[CurrentTime]}");
            CurrentTime++;
        }

        public void Rewind()
        {
            CurrentTime = 1;
        }

        public override void PlayWholeMovie()
        {
            foreach (string scence in Scenes)
            {
                Console.WriteLine($"{scence}");
            }
        }
    }
}
