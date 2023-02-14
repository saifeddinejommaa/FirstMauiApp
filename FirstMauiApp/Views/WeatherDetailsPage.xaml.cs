using FirstMauiApp.ViewModels;

namespace FirstMauiApp.Views;

public partial class WeatherDetailsPage : ContentPage
{
    WeatherDetailsViewModel vm => BindingContext as WeatherDetailsViewModel;
    public WeatherDetailsPage(WeatherDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext= vm;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        vm.LoadWeatherDetails();
    }
}