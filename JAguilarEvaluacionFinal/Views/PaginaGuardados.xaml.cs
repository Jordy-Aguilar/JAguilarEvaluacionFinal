using Microsoft.Maui.Controls;

namespace JAguilarEvaluacionFinal;

public partial class PaginaGuardados : ContentPage
{
    private readonly AeropuertoBaseDatos _database;

    public PaginaGuardados()
    {
        InitializeComponent();
        _database = new AeropuertoBaseDatos();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        jaguilar_listView.ItemsSource = await _database.GetAeropuertosAsync();
    }
}
