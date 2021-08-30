using _12_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _12_IntroToAPI
{
    public class SWAPIService
    {
        private readonly HttpClient _client = new HttpClient();
        private string _urlBase;

        public SWAPIService(string urlBase)
        {
            _urlBase = urlBase;
        }

        public async Task<Person> GetPersonAsync(string url)
        {
            //Await is a keyword similar to .Result
            HttpResponseMessage response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                Person person = await response.Content.ReadAsAsync<Person>();
                return person;
            }

            return default;
        }

        public async Task<Person> GetPersonByIDAsync(string id)
        {
            return await GetPersonAsync(_urlBase+"/people/" + id);
        }

        public async Task<Vehicle> GetVehicleAsync(string url)
        {
            HttpResponseMessage response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                Vehicle vehicle = await response.Content.ReadAsAsync<Vehicle>();
                return vehicle;
            }

            return default;
        }

        //generic Method

        public async Task<T> GetTAsync<T>(string url)
        {
            HttpResponseMessage response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }

            return default;
        }

        //search method

        public async Task<SearchResult<Person>> GetPersonSearchAsync(string query)
        {
            HttpResponseMessage response = await _client.GetAsync(_urlBase+"/people?search=" + query);

            if(response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<Person>>();
            }

            return default;
        }

        // generic method for search that could work for Person, Vehilce or any other type we make

        public async Task<SearchResult<T>> GetSearchAsync<T>(string category, string query)
        {
            //HttpResponseMessage response = await _client.GetAsync("https://swapi.dev/api/" + category +"/?search=" + query); 
            HttpResponseMessage response = await _client.GetAsync(_urlBase + category +"/?search=" + query);
              

            if(response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<T>>();
            }

            return default;
        }

        public async Task<SearchResult<Vehicle>> GetVehicleSeachAsync(string query)
        {
            return await GetSearchAsync<Vehicle>("vehicles", query);
        }


    }
}
