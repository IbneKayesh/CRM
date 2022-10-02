using CRM.ViewModels;
using CRM.ViewPages;
using CRM.Views;

namespace CRM;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//Each Pages and ViewModels need to add here, otherwise pages navigations will not working

		//Views
		builder.Services.AddSingleton<LoginPage>();
		builder.Services.AddSingleton<HomePage>();
		builder.Services.AddSingleton<ChangePswdPage>();
		builder.Services.AddSingleton<OrderTrackingPage>();

        //View Models
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<HomeViewModel>();
        builder.Services.AddSingleton<ChangePswdViewModel>();
        builder.Services.AddSingleton<OrderTrackingViewModel>();


        return builder.Build();
	}
}
