using JAguilarEvaluacionFinal.Servicios;

namespace JAguilarEvaluacionFinal
{
    public partial class App : Application
    {
        public static IClienteApis ClienteAPI { get; set; }

        public static IBDDConexion DBConnection { get; set; }

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            MainPage = new AppShell();

            ClienteAPI = serviceProvider.GetRequiredService<IClienteApis>();
            DBConnection = serviceProvider.GetRequiredService<IBDDConexion>();
        }
    }
}
