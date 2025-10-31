using DesafioNavegacaoMaui.ViewModels;

namespace DesafioNavegacaoMaui.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
    }
}
