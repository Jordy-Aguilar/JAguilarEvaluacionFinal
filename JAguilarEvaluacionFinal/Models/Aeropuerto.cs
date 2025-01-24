using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAguilarEvaluacionFinal.Models
{
    public class Aeropuerto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pais {  get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Correo { get; set; }
        public string JAguilar { get; set; } = "JAguilar";
    }
}
