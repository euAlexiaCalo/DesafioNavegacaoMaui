using DesafioNavegacaoMaui.Views;

namespace DesafioNavegacaoMaui
{
    public partial class AppShell : Shell
    {
        public static bool _routes;
        public AppShell()
        {
            InitializeComponent();

            if (!_routes)
            {
                Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
                Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
                Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

                _routes = true;
            }
        }
    }
}
