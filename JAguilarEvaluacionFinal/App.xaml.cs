using JAguilarEvaluacionFinal.Servicios;

namespace JAguilarEvaluacionFinal
{
    public partial class App : Application
    {
        public static IAPIClient APIClient { get; set; }

        public static IDatabaseConnection DBConnection { get; set; }

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            MainPage = new AppShell();

            APIClient = serviceProvider.GetRequiredService<IAPIClient>();
            DBConnection = serviceProvider.GetRequiredService<IDatabaseConnection>();
        }
    }
}
