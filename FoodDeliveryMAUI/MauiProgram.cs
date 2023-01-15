namespace FoodDeliveryMAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
				fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
			})
            .UseMauiCommunityToolkit();

		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();


        return builder.Build();
	}
}
