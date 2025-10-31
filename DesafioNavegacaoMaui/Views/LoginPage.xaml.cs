using DesafioNavegacaoMaui.ViewModels;

namespace DesafioNavegacaoMaui.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}
