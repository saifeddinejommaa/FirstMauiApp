using Data.localDB.Repository;
using domain.models;
using FirstMauiApp.Views;

namespace FirstMauiApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new AppShell();
        Routing.RegisterRoute(nameof(NewRegionPage), typeof(NewRegionPage));
        Routing.RegisterRoute(nameof(WeatherDetailsPage), typeof(WeatherDetailsPage));
    }

    protected override void OnStart()
    {
        base.OnStart();
        //await Task.Run(async () => { await InitializeLocalDB(); });
    }

    private async Task InitializeLocalDB()
    {
        //RainRepository rainRepo = await RainRepository.createIntance();

        //WeatherRepository weatherRepo = await WeatherRepository.createIntance();

        //WeatherSequenceRepository weatherSequenceRepo = await WeatherSequenceRepository.createIntance();

        //WeatherStateRepository weatherStateRepository = await WeatherStateRepository.createIntance();

        //WeatherDetailsRepository weatherDetailsRepository = await WeatherDetailsRepository.createIntance() ;
        
        //RegionRepository regionRepo = await RegionRepository.createIntance();
        


    }
}
