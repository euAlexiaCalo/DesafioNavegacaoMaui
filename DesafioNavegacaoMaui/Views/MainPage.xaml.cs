using DesafioNavegacaoMaui.ViewModels;

namespace DesafioNavegacaoMaui.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
