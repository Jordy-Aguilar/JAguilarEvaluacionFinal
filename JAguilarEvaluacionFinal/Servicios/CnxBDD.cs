using JAguilarEvaluacionFinal.Models;
using SQLite;

namespace JAguilarEvaluacionFinal.Servicios
{
    public class CnxBDD : IBDDConexion
    {
        private readonly SQLiteConnection SQLiteConnection;

        public CnxBDD ()
        {
            SQLiteConnection = new(Path.Combine(FileSystem.CacheDirectory, "airports.db"));
            SQLiteConnection.CreateTable<Aeropuerto>();
        }

        public List<Aeropuerto> GetAllAirports()
        {
            return SQLiteConnection.Query<Aeropuerto>("SELECT * FROM Aeropuerto ORDER BY Id DESC");
        }

        public void SaveAirport(Aeropuerto aeropuerto)
        {
            SQLiteConnection.Insert(aeropuerto);
        }
    }
}
