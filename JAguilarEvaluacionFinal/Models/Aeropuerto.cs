﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAguilarEvaluacionFinal.Models
{
    public class Aeropuerto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country {  get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Email { get; set; }
        public string MyName { get; set; } = "Jordy Aguilar";
    }
}
