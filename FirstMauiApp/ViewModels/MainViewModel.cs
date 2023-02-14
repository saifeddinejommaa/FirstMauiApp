
using domain.useCases;
using FirstMauiApp.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace FirstMauiApp.ViewModels
{
    public partial class MainViewModel: ObservableObject
    {
        private RegionUseCase _useCase;
        public ICommand AddNewCountryCommand { get; }

        [ObservableProperty]
        List<domain.models.Region> regions;
        public MainViewModel(RegionUseCase regionUseCase) {
            _useCase = regionUseCase;
            AddNewCountryCommand = new Command(async => { Navigate(); });
        
        }
        
        Task Navigate()
        {
           
            return Shell.Current.GoToAsync(nameof(NewRegionPage));
        }

        public async void InitializeAsync()
        {
            Regions = await _useCase.getAllRegions();
        }

        internal void OnItemSelected(int index)
        {
            Shell.Current.GoToAsync($"{nameof(WeatherDetailsPage)}?Id={Regions[index].Id}");
           
        }
    }
}
