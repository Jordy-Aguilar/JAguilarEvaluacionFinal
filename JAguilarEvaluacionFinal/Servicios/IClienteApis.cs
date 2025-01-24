using JAguilarEvaluacionFinal.Models;

namespace JAguilarEvaluacionFinal.Servicios
{
    public interface IClienteApis
    {
        public Task<BaseDeDatos?> GetAirport(string name);
    }
}

