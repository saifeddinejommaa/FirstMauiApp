using FirstMauiApp.ViewModels;

namespace FirstMauiApp;

public partial class MainPage : ContentPage
{
    MainViewModel vm => BindingContext as MainViewModel;
    public MainPage(MainViewModel vm)	{
		InitializeComponent();
		BindingContext = vm;
	}


    protected override void OnAppearing()
    {
        base.OnAppearing();
        vm.InitializeAsync();
    }

    private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        vm.OnItemSelected(e.SelectedItemIndex);
    }
}

