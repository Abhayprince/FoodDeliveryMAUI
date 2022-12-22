namespace FoodDeliveryMAUI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public Category(int id, string name, string image) : this()
        {
            Id = id;
            Name = name;
            Image = image;
        }
        public Category()
        {

        }
    }
}
