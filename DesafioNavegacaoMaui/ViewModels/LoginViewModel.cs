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
    public partial class LoginViewModel : INotifyPropertyChanged
    {
        private string _email;
        private string _senha;

        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Senha
        {
            get => _senha;
            set
            {
                if (_senha != value)
                {
                    _senha = value;
                    OnPropertyChanged();
                }
            }
        }
        public Command LogarCommand { get; set; }
        public LoginViewModel()
        {
            LogarCommand = new Command(async () =>
            {
                if (string.IsNullOrEmpty(Email) || string.IsNullOrWhiteSpace(Senha))
                {
                    await Shell.Current.DisplayAlert("Erro", "Todos os campos devem ser preenchidos.", "OK");
                    return;
                }
                if (Email == "email@email.com" && Senha == "1234")
                {
                    await Shell.Current.GoToAsync(nameof(HomePage));
                }
            });
        }
        // Aviso de evento para notificar a view sobre as mudanças
        public event PropertyChangedEventHandler? PropertyChanged;

        // Método que dispara o evento PropertyChanged para notificar a View sobre mudanças nas propriedades do ViewModel
        void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
