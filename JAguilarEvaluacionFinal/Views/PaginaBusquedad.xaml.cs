using JAguilarEvaluacionFinal.Servicios;
using JAguilarEvaluacionFinal.Models;
 
namespace JAguilarEvaluacionFinal.Views;

public partial class PaginaBusqueda : ContentPage
{
    private ServicioAeropuerto servicio;

    public PaginaBusqueda()
    {
        InitializeComponent();
        servicio = new ServicioAeropuerto();
    }

    private async void OnBuscarClicked(object sender, EventArgs e)
    {
        var nombre = NombreAeropuerto.Text;

        if (!string.IsNullOrWhiteSpace(nombre))
        {
            Resultado.Text = "Buscando...";
            var aeropuerto = await servicio.BuscarAeropuerto(nombre);

            if (aeropuerto != null)
            {
                Resultado.Text = $"Nombre: {aeropuerto.Name}\n" +
                $"Pa�s: {aeropuerto.Country}\n" +
                                                 $"IATA: {aeropuerto.Iata}\n" +
                                                 $"Latitud: {aeropuerto.Latitude}\n" +
                                                 $"Longitud: {aeropuerto.Longitude}";
            }
            else
            {
                Resultado.Text = "No se encontr� ning�n aeropuerto con ese nombre.";
            }
        }
        else
        {
            Resultado.Text = "Ingrese un nombre v�lido.";
        }
    }
}