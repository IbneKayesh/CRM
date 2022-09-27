using CRM.ViewModels;

namespace CRM.Views;

public partial class HomePage : ContentPage
{
    public HomePage(HomeViewModel obj)
    {
        InitializeComponent();
        this.BindingContext = obj;
    }
}