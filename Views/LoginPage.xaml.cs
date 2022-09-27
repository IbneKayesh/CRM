using CRM.ViewModels;

namespace CRM.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel obj)
	{
		InitializeComponent();
		this.BindingContext = obj;
	}
}