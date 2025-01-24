namespace JAguilarEvaluacionFinal.Models
{
    public class Ubicacion
    {
        public float Latitud { get; set; }
        public float Longitud { get; set; }
    }

    public class InformacionContacto
    {
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string SitioWeb { get; set; }
    }

    public class Terminal
    {
        public string Nombre { get; set; }
        public Puerta[] Puertas { get; set; }
    }

    public class Puerta
    {
        public string NumeroPuerta { get; set; }
        public string[] Aerolineas { get; set; }
    }

    public class BaseDeDatos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string ZonaHoraria { get; set; }
        public Terminal[] Terminales { get; set; }
        public string[] Aerolineas { get; set; }
        public string[] Servicios { get; set; }
        public InformacionContacto InformacionContacto { get; set; }
    }
}
