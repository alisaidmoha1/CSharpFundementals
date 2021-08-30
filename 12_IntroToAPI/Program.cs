using _12_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _12_IntroToAPI
{
    public class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            //var response = client.GetAsync("https://swapi.dev/api/people/1");
            HttpResponseMessage response = client.GetAsync("https://swapi.dev/api/people/1").Result;

            // translating JSON to C#
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content;
                string contentsString = content.ReadAsStringAsync().Result;
                //Console.WriteLine(contentsString);

                Person person = content.ReadAsAsync<Person>().Result;
                Console.WriteLine($"{person.Name,5}: {person.Height,3}cm, {person.Mass,3}kg");

                foreach (string vehicleUrl in person.Vehicles)
                {
                    HttpResponseMessage vehicleResponse = client.GetAsync(vehicleUrl).Result;

                    Vehicle vehicle = content.ReadAsAsync<Vehicle>().Result;
                    //Console.WriteLine($"{vehicle.Name}, {vehicle.Model}");
                }
            }


            Console.ReadKey();
            Console.Clear();

            SWAPIService service = new SWAPIService("https://swapi.dev/api/");
            while (true)
            {
                Console.Write("Enter an ID: ");
                string id = Console.ReadLine();

                if (id == "no")
                {
                    break;
                }

                Person person2 = service.GetPersonByIDAsync(id).Result;

                Console.WriteLine(person2.Name);

                foreach (string vehilcleUrl in person2.Vehicles)
                {
                    var vehicle = service.GetTAsync<Vehicle>(vehilcleUrl).Result;
                    Console.WriteLine($" {vehicle.Name}");
                }

                Console.ReadKey();
            }
            Console.WriteLine("Search for a vehicle");
            string query = Console.ReadLine();
            var results = service.GetVehicleSeachAsync(query).Result.Results;
            Console.WriteLine($"{results.Count} vehicles found");
           foreach (Vehicle vehicle1 in results)
            {
                Console.WriteLine($"{vehicle1.Name}, {vehicle1.Model}");
            }

            Console.ReadKey();
        }


    }
}

