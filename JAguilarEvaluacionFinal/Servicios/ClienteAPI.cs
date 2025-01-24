using JAguilarEvaluacionFinal.Models;
using System.Net.Http.Json;

namespace JAguilarEvaluacionFinal.Servicios
{
   
    public class ClienteAPI : IClienteApis
    {
        private readonly HttpClient HttpClient = new();

        public async Task<BaseDeDatos?> GetAirport(string name)
        {
            try
            {
                List<BaseDeDatos>? airports = await HttpClient.GetFromJsonAsync<List<BaseDeDatos>>($"https://www.freetestapi.com/api/v1/airports?search={name}&limit=1");

              
                if (airports == null || airports.Count == 0)
                {
                    return null;
                }

                return airports[0]; 
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"Error al obtener los datos del aeropuerto: {ex.Message}");
                return null;
            }
        }
    }
}
