using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inhertance.Content
{
    public class Show : StreamingContent
    {
        public List<Episode> Episodes { get; set; } = new List<Episode>();

        public int  SeasonCount { get; set; }
        public int EpisodeCount { get
            {
                return Episodes.Count; // will get the accurate count of Espisodes
            }
         }
        public double AverageRunTime { get 
            
            {
                // double totalRunTime
                //for each episode
                /// add runTime to total
                /// divide toital by count
                /// 
                double totalRunTime = 0;
                foreach(Episode episode in Episodes)
                {
                    totalRunTime += episode.RunTime;
                }
                return totalRunTime / EpisodeCount;

                //fancy way (with linq)

                return Episodes.Select(e => e.RunTime).Sum() / EpisodeCount;

                //List<string> episodeNames = Episodes.Selec(e => e.Title).ToList();
            
            } 
        }
    }

    public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
    }
}
