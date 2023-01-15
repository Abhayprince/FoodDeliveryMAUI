
using CommunityToolkit.Mvvm.Input;
using System.Net.Http.Json;

namespace FoodDeliveryMAUI.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private IEnumerable<Category> _categories;

        [ObservableProperty]
        private IEnumerable<Offer> _offers;
        private readonly HttpClient _httpClient;

        public MainViewModel(IHttpClientFactory httpClientFactory)
        {
            //Categories = LoadCategories();
            Offers = LoadDummyOffers();
            _httpClient = httpClientFactory.CreateClient(AppConstants.ApiHttpClientName);
        }

        public async Task InitializeAsync()
        {
            // ITS ERRORING OUT NEED TO BE FIXED, 
            // COMMENTED FOR NOW, WILL FIX IN NEXT VIDEO
            //Categories = await LoadCategoriesAsync();

            Categories = LoadCategories();
        }

        [RelayCommand]
        private async Task SelectOfferAsync(Offer offer)
        {
            await Shell.Current.DisplayAlert("Offer Tapped", $"Offer {offer} is selected. We will move to a new page for offer details", "Ok");
        }
        private async Task<IEnumerable<Category>> LoadCategoriesAsync()
        {
            var categories = await _httpClient.GetFromJsonAsync<IEnumerable<Category>>("https://localhost:7293/api/categories");
            return categories;
        }
        //private static IEnumerable<Category> LoadCategories()
        //{
        //    return new List<Category>
        //    {
        //        new Category(1, "Burgers", "burgers.png"),
        //        new Category(2, "Desserts", "desserts.png"),
        //        new Category(3, "Drinks", "drinks.png"),
        //        new Category(4, "Non-Veg", "nonveg.png"),
        //        new Category(5, "Pizza", "pizza.png"),
        //        new Category(6, "Rice", "rice.png"),
        //        new Category(7, "Seafood", "seafood.png"),
        //        new Category(8, "Soups", "soups.png"),
        //        new Category(9, "Veg", "veg.png"),
        //    };
        //}
        private static IEnumerable<Offer> LoadDummyOffers()
        {
            return new List<Offer>
            {
                new Offer(1, "50 Percent Off", "percent_50p.jpg","50 Percent off on all food items", "OFF-50", OfferType.Percentage, 50, null, DateTime.Now.AddDays(7)),
                new Offer(2, "Hot Offer", "hot_offer.jpg","Hot Offer", "HOT-80", OfferType.Percentage, 80, null, DateTime.Now.AddDays(2)),
                new Offer(3, "Upto 25% OFF", "upto_25_percent.png","Upto 25% OFF", "UPTO-25", OfferType.Percentage, 25, 500, null, "Yellow"),
                new Offer(4, "Half Price", "half_price.jpg","Half Price", "HALF", OfferType.Percentage, 50, 1000, DateTime.Now.AddDays(2), "Red"),
                new Offer(5, "Flat Rs. 100 Off Today Only", "today_only.png","Flat Rs. 100 Off Today Only", "100-TODAY", OfferType.Flat, 100, null, DateTime.Today),
                new Offer(6, "30% OFF", "thirty_percent.jpg","50", "OFF", OfferType.Percentage, 30, 300, DateTime.Now.AddMonths(1), "#FFFFFF"),
                new Offer(7, "Special Festival Offer", "special_offer.png","Special Festival Offer", "FEST-150", OfferType.Flat, 150, null, DateTime.Now.AddDays(5)),
                new Offer(8, "SALE 40% OFF", "sale_40_percent.jpg","SALE 40% OFF", "SALE-40", OfferType.Percentage, 40, null, DateTime.Now.AddDays(4), "Gray"),
                new Offer(9, "50% OFF", "fifty_percent_off.png","50% OFF", "50-OFF", OfferType.Percentage, 50, null, DateTime.Today),
            };
        }
    }
}
