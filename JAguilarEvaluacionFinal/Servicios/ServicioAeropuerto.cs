using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JAguilarEvaluacionFinal.Servicios
{
    public class ServicioAeropuerto
    {
        private readonly HttpClient _clienteHttp;

        public ServicioAeropuerto()
        {
            _clienteHttp = new HttpClient();
        }

        public async Task<JObject> BuscarAeropuertoAsync(string consulta)
        {
            string url = $"https://aviation-edge.com/v2/public/airportDatabase?key=YOUR_API_KEY&codeIataAirport={consulta}";
            var respuesta = await _clienteHttp.GetStringAsync(url);
            return JObject.Parse(respuesta);
        }
    }
}
