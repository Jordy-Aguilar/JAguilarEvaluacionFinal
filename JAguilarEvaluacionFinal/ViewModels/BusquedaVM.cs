using JAguilarEvaluacionFinal.Models;
using JAguilarEvaluacionFinal.Servicios;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace JAguilarEvaluacionFinal.ViewModels
{
    public class BusquedaVM : INotifyPropertyChanged
    {
        public string Busqueda { get; set; }

        public string Resultado { get; set; }

        public ICommand BusquedaCommand { get; set; }

        public ICommand LimpiarCommand { get; set; }

        public BusquedaVM()
        {
            Busqueda = "";
            Resultado = "";

            BusquedaCommand = new Command(async () =>
            {
                BaseDeDatos? baseDeDatos = await App.ClienteAPI.GetAirport(Busqueda);

                if (baseDeDatos != null)
                {
                    App.DBConnection.SaveAirport(ServicioAeropuerto.Convert(baseDeDatos));
                }

                Resultado = baseDeDatos == null ? "Error: No se encontró el registro" : baseDeDatos.name;
                OnPropertyChanged(nameof(Resultado));
            });

            LimpiarCommand = new Command(() =>
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
