using CommunityToolkit.Mvvm.Input;
using CRM.ViewPages;

namespace CRM.ViewModels
{
    public partial class AppShellViewModel : BaseViewModel
    {
        [RelayCommand]
        public async void Logout()
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
