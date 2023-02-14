
using Data.ApiService.Repositories;
using Data.localDB.Repository;
using domain.LocalDataRepositories;
using domain.RemoteRepositories;
using domain.useCases;
using FirstMauiApp.Views;

namespace FirstMauiApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .RegisterViews()
            .RegisterViewModels()
            .RegisterUsesCases()
            .RegisterLocalDBProviders()
            .RegisterDistantRepositories()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont(filename: "materialdesignicons-webfont.ttf", alias: "MaterialDesignIcons");
			});

		return builder.Build();
	}

	public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
	{
        builder.Services.AddSingleton<ViewModels.MainViewModel>();
        builder.Services.AddTransient<ViewModels.NewRegionPageViewModel>();
		builder.Services.AddSingleton<ViewModels.WeatherDetailsViewModel>();

		return builder;
    }

	public static MauiAppBuilder RegisterUsesCases(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<RegionUseCase>();
		return builder;
	}

	public static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<NewRegionPage>();
		builder.Services.AddTransient<WeatherDetailsPage>();

		return builder;
	}

	public static MauiAppBuilder RegisterLocalDBProviders(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<IRegionRepository, RegionRepository>();
        return builder;
    }

	public static MauiAppBuilder RegisterDistantRepositories(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<IDistantRegionRepository,DistantRegionRepository>();
        return builder;
    }
}
