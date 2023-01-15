namespace FoodDeliveryMAUI;

public partial class MainPage : ContentPage
{
	private readonly MainViewModel _viewModel;

	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		_viewModel = viewModel;
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();
		await _viewModel.InitializeAsync();
	}
}

