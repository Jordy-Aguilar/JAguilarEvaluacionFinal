using JAguilarEvaluacionFinal.Models;
using JAguilarEvaluacionFinal.Servicios;  
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace JAguilarEvaluacionFinal.ViewModels
{
    public class PaginaBusqueda : INotifyPropertyChanged
    {
        public string Busqueda { get; set; }

        public string Resultado { get; set; }

        public ICommand ComandoBusqueda { get; set; }

        public ICommand ComandoLimpiar { get; set; }

        public PaginaBusqueda()
        {
            Busqueda = "";
            Resultado = "";

            ComandoBusqueda = new Command(async () =>
            {
                Aeropuerto? aeropuertoJSON = await App.APIClient.GetAirport(Busqueda);

                if (aeropuertoJSON != null)
                {
                    App.DBConnection.SaveAirport(AirportConverter.Convert(aeropuertoJSON));
                }

                Resultado = aeropuertoJSON == null ? "Error: No se encontró el registro" : Aeropuerto.Nombre;
                OnPropertyChanged(nameof(Resultado));
            });

            ComandoLimpiar = new Command(() =>
            {
                Busqueda = "";
                Resultado = "";

                OnPropertyChanged(nameof(Busqueda));
                OnPropertyChanged(nameof(Resultado));
            });
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
