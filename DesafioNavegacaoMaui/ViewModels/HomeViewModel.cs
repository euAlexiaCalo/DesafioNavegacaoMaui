using DesafioNavegacaoMaui.Views;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesafioNavegacaoMaui.ViewModels
{
    public partial class HomeViewModel : INotifyPropertyChanged
    {
        public Command SairCommand { get; set; }
        public HomeViewModel()
        {
            SairCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            });
        }
        // Aviso de evento para notificar a view sobre as mudanças
        public event PropertyChangedEventHandler? PropertyChanged;

        // Método que dispara o evento PropertyChanged para notificar a View sobre mudanças nas propriedades do ViewModel
        void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
