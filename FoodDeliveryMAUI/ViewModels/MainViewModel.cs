
namespace FoodDeliveryMAUI.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private IEnumerable<Category> _categories;

        public MainViewModel()
        {
            Categories = LoadCategories();
        }

        private static IEnumerable<Category> LoadCategories()
        {
            return new List<Category>
            {
                new Category(1, "Burgers", "burgers.png"),
                new Category(2, "Desserts", "desserts.png"),
                new Category(3, "Drinks", "drinks.png"),
                new Category(4, "Non-Veg", "nonveg.png"),
                new Category(5, "Pizza", "pizza.png"),
                new Category(6, "Rice", "rice.png"),
                new Category(7, "Seafood", "seafood.png"),
                new Category(8, "Soups", "soups.png"),
                new Category(9, "Veg", "veg.png"),
            };
        }
    }
}
