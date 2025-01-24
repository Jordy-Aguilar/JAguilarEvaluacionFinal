using JAguilarEvaluacionFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace JAguilarEvaluacionFinal.Datos
{
    public class BaseDeDatos
    {
        private readonly SQLiteAsyncConnection _baseDeDatos;
        public BaseDeDatos(string rutaBD)
        {
            _baseDeDatos = new SQLiteAsyncConnection(rutaBD);
            _baseDeDatos.CreateTableAsync<Aeropuerto>().wait();
        }
        public Task<List<Aeropuerto>> ObtenerAeropuertoAsyn()
        {
            return _baseDeDatos.Table<Aeropuerto>().ToListAsync();  
        }
        public Task<int> GuardarAeropuertoAsync(Aeropuerto aeropuerto)
        {
            return _baseDeDatos.InsertAsync(aeropuerto);
        }

    }
}
