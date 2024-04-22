using Newtonsoft.Json;
using Gray_API_pt2.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Gray_API_pt2
{
    public class JSONHelper
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<Planet> GetPlanet(string apiUrl, int planetId)
        {
            Planet MyDeserializedClass2 = new Planet();
            try
            {
                HttpResponseMessage response = await client.GetAsync($"http://swapi.py4e.com/api/planets/{planetId}/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                MyDeserializedClass2 = JsonConvert.DeserializeObject<Planet>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return MyDeserializedClass2;
        }
        public static async Task<Person> GetPerson(string apiUrl, int personId)
        {
            Person MyDeserializedClass = new Person();
            try
            {
                HttpResponseMessage response = await client.GetAsync($"http://swapi.py4e.com/api/people/{personId}/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                MyDeserializedClass = JsonConvert.DeserializeObject<Person>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return MyDeserializedClass;
        }
        public static async Task<Species> GetSpecies(string apiUrl)
        {
            Species MyDeserializedClass = new Species();
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://swapi.py4e.com/api/species/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                MyDeserializedClass = JsonConvert.DeserializeObject<Species>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return MyDeserializedClass;
        }
    }
}