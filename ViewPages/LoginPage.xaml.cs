using CRM.ViewModels;

namespace CRM.ViewPages;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel obj)
    {
        InitializeComponent();
        this.BindingContext = obj;
    }
}