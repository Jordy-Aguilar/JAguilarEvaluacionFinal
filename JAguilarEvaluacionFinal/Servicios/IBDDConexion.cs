using JAguilarEvaluacionFinal.Models;

namespace JAguilarEvaluacionFinal.Servicios
{
    public interface IBDDConexion
    {
        public void SaveAirport(Aeropuerto aeropuerto);

        public List<Aeropuerto> GetAllAirports();
    }
}
