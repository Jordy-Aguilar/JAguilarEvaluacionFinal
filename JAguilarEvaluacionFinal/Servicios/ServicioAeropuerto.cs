using JAguilarEvaluacionFinal.Models;

namespace JAguilarEvaluacionFinal.Servicios
{
    public class ServicioAeropuerto
    {
        public static Aeropuerto Convert(BaseDeDatos baseDeDatos)
        {
            return new ()
            {
                Name = baseDeDatos.name,
                Country = baseDeDatos.country,
                Latitude = baseDeDatos.location.latitude,
                Longitude = baseDeDatos.location.longitude,
                Email = baseDeDatos.contact_info.email
            };
        }
    }
}
