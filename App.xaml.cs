using CRM.Views;

namespace CRM;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		Routing.RegisterRoute(nameof(HomePage),typeof(HomePage));
	}
}
