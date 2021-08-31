using _12_APIChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _12_APIChallenge
{
    public class Program
    {
       public static void Main(string[] args)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = client.GetAsync("https://rickandmortyapi.com/api/").Result;

            RickAndMortyService service = new RickAndMortyService();

            Episodes rick = service.GetEpisodesAsync("https://rickandmortyapi.com/api/episode/").Result;
            Console.WriteLine(rick.Results);

            //foreach (var EpisodeUrl in rick.Results)
            //{
            //    );
            //}

            //foreach (var EposideUrl in rick.)
            //{
            //    var episode = service.GetRickAndAsync(EposideUrl).Result;
            //    Console.WriteLine($"{episode.Characters}, {episode.Locations}");
            //}
            Console.ReadKey();
        }
    }
}
