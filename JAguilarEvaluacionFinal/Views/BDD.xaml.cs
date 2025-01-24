using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace JAguilarEvaluacionFinal.Views
{
    public class BDD : INotifyPropertyChanged
    {
        public List<string> Aeropuertos => App.DBConnection.GetAllAirports().Select(x => $"Nombre: {x.Nombre}, País: {x.Pais}, Latitud: {x.Latitud}, Longitud: {x.Longitud}, Correo: {x.Correo}, Mi nombre: {x.MiNombre}").ToList();

        public ICommand ComandoActualizar { get; set; }

        public BDD()
        {
            ComandoActualizar = new Command(() =>
            {
                OnPropertyChanged(nameof(Aeropuertos));
            });
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
