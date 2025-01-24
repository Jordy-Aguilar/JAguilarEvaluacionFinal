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
        public double latitud { get; set; }
        public double longitud { get; set; }
        public string correo { get; set; }
        public string usuario { get; set; }
    }
}
