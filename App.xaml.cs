using CRM.ViewModels;

namespace CRM;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
        this.BindingContext = new AppShellViewModel();
        //Routing.RegisterRoute(nameof(HomePage),typeof(HomePage));
    }
}
