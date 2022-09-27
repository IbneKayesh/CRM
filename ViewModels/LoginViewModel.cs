using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CRM.Views;
using System.Windows.Input;

namespace CRM.ViewModels
{
    public partial class LoginViewModel:BaseViewModel
    {
        #region Commands

        public ICommand Login { private set; get; }

        public LoginViewModel()
        {
            Login = new Command(
              execute: () =>
              {
                  LoginCommand();
              });
        }
        async void LoginCommand()
        {
           await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
        #endregion
    }
}
