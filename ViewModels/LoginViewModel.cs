using CommunityToolkit.Mvvm.Input;
using CRM.Models;
using CRM.ViewPages;

namespace CRM.ViewModels
{
    public partial class LoginViewModel:BaseViewModel
    {
        //Property
        public string user_id { get; set; }
        public string user_pswd { get; set; }
        //Property

        [RelayCommand]
        public async void Login()
        {
            //validations
            if (string.IsNullOrWhiteSpace(user_id) || string.IsNullOrWhiteSpace(user_pswd))
            {
                await Shell.Current.CurrentPage.DisplayAlert("Error", "User Id and Password is Required", "Ok");
                return;
            }

            //API/Database Object Conversion
            var user_login = new USER_LOGIN
            {
                USER_ID = user_id,
                USER_PSWD = user_pswd
            };
            //End API/Database Object Conversion

            //Call Api
            var obj = CRM.Services.CRM.UserService.ValidateUser(user_login);

            if (obj)
            {
                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
            else
            {
                await Shell.Current.CurrentPage.DisplayAlert("Login Failed","User or Password is Invalid", "Ok");
            }

        }



        #region Test Commands

        //public ICommand Login { private set; get; }

        //public LoginViewModel()
        //{
        //    Login = new Command(
        //      execute: () =>
        //      {
        //          LoginCommand();
        //      });
        //}
        //async void LoginCommand()
        //{
        //   await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        //}
        #endregion
    }
}
