using CommunityToolkit.Mvvm.Input;
using CRM.Services.Db;

namespace CRM.ViewModels
{
    public partial class ChangePswdViewModel : BaseViewModel
    {
        public ChangePswdViewModel()
        {
            Title = "Change Password";
        }
        //Property
        public string user_id { get; set; } = AppsData.USER_ID;
        public string user_pswd { get; set; }
        public string user_pswd_new { get; set; }
        public string user_pswd_conf { get; set; }

        //Property

        [RelayCommand]
        async void ChangePassword()
        {
            //validations
            if (string.IsNullOrWhiteSpace(user_id) ||
                string.IsNullOrWhiteSpace(user_pswd) ||
                string.IsNullOrWhiteSpace(user_pswd_new))
            {
                await Shell.Current.CurrentPage.DisplayAlert("Error", "User Id, Old and New Password is Required", "Ok");
                return;
            }
            if(user_pswd_new != user_pswd_conf)
            {
                await Shell.Current.CurrentPage.DisplayAlert("Error", "New and Confirm Password is not matched", "Ok");
                return;
            }
            await Shell.Current.CurrentPage.DisplayAlert("Success", "Password changes success", "Ok");
        }

    }
}
