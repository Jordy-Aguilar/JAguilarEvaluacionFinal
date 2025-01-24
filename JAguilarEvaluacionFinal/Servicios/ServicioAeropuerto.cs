using JAguilarEvaluacionFinal.Models;

namespace JAguilarEvaluacionFinal.Servicios
{
    public class ServicioAeropuerto
    {
        public static Aeropuerto Convert(BaseDeDatos baseDeDatos)
        {
            return new Aeropuerto
            {
                Nombre = baseDeDatos.Nombre,
                Pais = baseDeDatos.Pais,
                Latitud = baseDeDatos.Ubicacion.Latitud,   
                Longitud = baseDeDatos.Ubicacion.Longitud, 
                Correo = baseDeDatos.InformacionContacto.Correo 
            };
        }
    }
}
