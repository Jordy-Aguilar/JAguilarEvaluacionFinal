using System.Net.Http.Json;
using Microsoft.Maui.Controls;

namespace JAguilarEvaluacionFinal;

public partial class PaginaBusquedad : ContentPage
{
    private readonly AeropuertoBaseDatos _database;

    public PaginaBusquedad()
    {
        InitializeComponent();
        _database = new AeropuertoBaseDatos();
    }

    private async void OnSearchButtonClicked(object sender, EventArgs e)
    {
        string nombrePais = jaguilar_searchEntry.Text;

        if (string.IsNullOrWhiteSpace(nombrePais))
        {
            await DisplayAlert("Error", "Ingrese un nombre válido.", "OK");
            return;
        }

        try
        {
            using HttpClient client = new HttpClient();
            string url = $"https://freetestapi.com/api/v1/airports?search={nombrePais}&limit=1";
            var response = await client.GetFromJsonAsync<List<Aeropuerto>>(url);

            if (response != null && response.Any())
            {
                var aeropuerto = response.First();
                jaguilar_resultLabel.Text = $"Nombre: {aeropuerto.Nombre}, País: {aeropuerto.Pais}, Latitud: {aeropuerto.Latitud}, Longitud: {aeropuerto.Longitud}, Correo: {aeropuerto.Correo}";

                // Guardar en la base de datos
                await _database.SaveAeropuertoAsync(aeropuerto);
            }
            else
            {
                jaguilar_resultLabel.Text = "No se encontraron aeropuertos.";
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }

    private void OnClearButtonClicked(object sender, EventArgs e)
    {
        jaguilar_searchEntry.Text = string.Empty;
        jaguilar_resultLabel.Text = string.Empty;
    }
}
