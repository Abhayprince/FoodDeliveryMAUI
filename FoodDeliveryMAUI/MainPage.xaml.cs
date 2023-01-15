namespace FoodDeliveryMAUI;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }

	private void Offer_Tapped(object sender, EventArgs e)
	{

	}
}

