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

		//Views
		builder.Services.AddSingleton<LoginPage>();
		builder.Services.AddSingleton<HomePage>();
		builder.Services.AddSingleton<ChangePswdPage>();

        //View Models
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<HomeViewModel>();
        builder.Services.AddSingleton<ChangePswdViewModel>();


        return builder.Build();
	}
}
