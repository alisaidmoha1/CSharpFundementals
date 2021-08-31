using _12_APIChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _12_APIChallenge
{
    public class RickAndMortyService
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<RickAndMorty> GetRickAndAsync (string url)
        {
            HttpResponseMessage response = await _client.GetAsync(url);

            return response.IsSuccessStatusCode ? await response.Content.ReadAsAsync<RickAndMorty>() : null;
        }

        public async Task<Episodes> GetEpisodesAsync(string url)
        {
            HttpResponseMessage response = await _client.GetAsync(url);

            return response.IsSuccessStatusCode ? await response.Content.ReadAsAsync<Episodes>() : null;
        }
    }
}
