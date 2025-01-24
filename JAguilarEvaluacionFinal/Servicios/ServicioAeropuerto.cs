using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using JAguilarEvaluacionFinal.Models;

namespace JAguilarEvaluacionFinal.Servicios;

public class ServicioAeropuerto
{
    private const string ApiBaseUrl = "https://freetestapi.com/api/v1/airports?search={name}";

    public async Task<Aeropuerto?> BuscarAeropuerto(string nombre)
    {
        try
        {
            using (var client = new HttpClient())
            {
                string url = $"{ApiBaseUrl}{nombre}&limit=1";

                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var aeropuertos = JsonConvert.DeserializeObject<List<Aeropuerto>>(json);

                    return aeropuertos.Count > 0 ? aeropuertos[0] : null;
                }
                else
                {
                    return null;
                }
            }
        }
        catch
        {
            return null;
        }
    }
}