using FirstMauiApp.ViewModels;

namespace FirstMauiApp.Views;

public partial class NewRegionPage : ContentPage
{
	//private NewRegionPageViewModel viewModel=> BindingContext as NewRegionPageViewModel;
	public NewRegionPage(NewRegionPageViewModel vm)
	{
		InitializeComponent();
		BindingContext=vm;
	}
}