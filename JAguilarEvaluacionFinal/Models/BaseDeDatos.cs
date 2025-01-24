using SQLite;

public class BaseDeDatos
{
    private readonly SQLiteAsyncConnection _database;

    public BaseDeDatos()
    {
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "jaguilar_aeropuertos.db3");
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Aeropuerto>().Wait();
    }

    public Task<List<Aeropuerto>> GetAeropuertosAsync()
    {
        return _database.Table<Aeropuerto>().ToListAsync();
    }

    public Task<int> SaveAeropuertoAsync(Aeropuerto aeropuerto)
    {
        return _database.InsertAsync(aeropuerto);
    }
}
