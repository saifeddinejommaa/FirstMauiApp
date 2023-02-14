using domain.models;
using domain.useCases;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace FirstMauiApp.ViewModels
{
    [QueryProperty(nameof(Id),nameof(Id))]
    public partial class WeatherDetailsViewModel : ObservableObject
    {
        private RegionUseCase _useCase;
        public int Id { get; set; }

        [ObservableProperty]
        domain.models.Region currentRegion;

        [ObservableProperty]
        WeatherState weatherState;

        private domain.models.WeatherDetails _currentWeather;
        public domain.models.WeatherDetails CurrentWeather
        {
            get
            {
                return _currentWeather;
            }

            set
            {
                if (value != _currentWeather)
                {
                    _currentWeather = value;
                    OnPropertyChanged(nameof(CurrentWeather));
                    WeatherState = value.Current;
                }
            }
        }
        


        public WeatherDetailsViewModel(RegionUseCase regionUseCase) {
            _useCase = regionUseCase;
        }

        public async void LoadWeatherDetails()
        {
            CurrentRegion = await _useCase.GetRegionById(Id);
            CurrentWeather= await _useCase.getWeatherDetails(currentRegion.Lat,currentRegion.Lng);
            
        }
    }
}
