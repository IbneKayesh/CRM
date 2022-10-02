using CRM.ViewModels;

namespace CRM.ViewPages;

public partial class HomePage : ContentPage
{
    public HomePage(HomeViewModel obj)
    {
        InitializeComponent();
        this.BindingContext = obj;
    }
}