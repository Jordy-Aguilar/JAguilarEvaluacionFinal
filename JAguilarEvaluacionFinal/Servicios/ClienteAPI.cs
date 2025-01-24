using JAguilarEvaluacionFinal.Models;
using System.Net.Http.Json;

namespace JAguilarEvaluacionFinal.Servicios
{
    public class ClienteAPI : APIPORCREAR
    {
        private readonly HttpClient HttpClient = new();

        public async Task<BaseDeDatos?> GetAirport(string name)
        {
            List<BaseDeDatos> airports = (await HttpClient.GetFromJsonAsync<List<BaseDeDatos>>($"https://www.freetestapi.com/api/v1/airports?search={name}&limit=1"))!;

            if (airports.Count == 0)
            {
                return null;
            }
            return airports[0];
        }
    }
}
