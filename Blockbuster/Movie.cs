using System;
using System.Collections.Generic;

namespace Blockbuster
{
    public abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }

        public List<string> Scenes = new List<string>();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Title} + {Category} + {RunTime}");
        }

        public void PrintScenes()
        {
            int i = 1;

            foreach(string Scence in Scenes)
            {
                Console.WriteLine($"[{i}] {Scence}");
                i++;
            }
        }

        public abstract void Play();
        public abstract void PlayWholeMovie();
    }

    
}
