using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace JAguilarEvaluacionFinal.ViewModels
{
    public class BDDVM : INotifyPropertyChanged
    {
        public List<string> Airports => App.DBConnection.GetAllAirports().Select(x => $"Nombre de Aeropuerto: {x.Name}, País: {x.Country}, Latitud: {x.Latitude}, Longitud: {x.Longitude}, Correo: {x.Email}, Usuario: {x.MyName}").ToList();

        public ICommand ActualizarCommand { get; set; }

        public BDDVM()
        {
            ActualizarCommand = new Command(() =>
            {
                OnPropertyChanged(nameof(Airports));
            });
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
