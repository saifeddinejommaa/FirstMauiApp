
using domain.useCases;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace FirstMauiApp.ViewModels
{
    public partial class NewRegionPageViewModel: ObservableObject
    {
        public ICommand SaveNewRegion { get; }
        private RegionUseCase _useCase;

        [ObservableProperty]
        public string lat;

        [ObservableProperty]
        public string lng;

        [ObservableProperty]
        public string name;
        public NewRegionPageViewModel(RegionUseCase regionUseCase) { 
         
            _useCase = regionUseCase;
            SaveNewRegion = new Command(async => SaveEvent()); 
        }

        private async void SaveEvent()
        {
            double lat = Double.Parse(Lat);
            double lng = Double.Parse(Lng);
            var result = await _useCase.insertNewRegion(new domain.models.Region(Name,lat, lng));
            if (result != 0)
            {
                await App.Current.MainPage.DisplayAlert("Region ajoutée avec succés", "Info", "OK");
            }
        }
    }
}
