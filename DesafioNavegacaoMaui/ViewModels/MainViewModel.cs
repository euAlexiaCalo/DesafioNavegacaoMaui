using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DesafioNavegacaoMaui.Views;

namespace DesafioNavegacaoMaui.ViewModels
{
    public partial class MainViewModel : INotifyPropertyChanged
    {
        public Command AcessarCommand { get; set; }
        public MainViewModel()
        {
            AcessarCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync(nameof(LoginPage));
            });
        }

        // Aviso de evento para notificar a view sobre as mudanças
        public event PropertyChangedEventHandler? PropertyChanged;

        // Método que dispara o evento PropertyChanged para notificar a View sobre mudanças nas propriedades do ViewModel
        void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
