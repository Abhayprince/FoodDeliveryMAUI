using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Api.Data.Entities
{
    [Table(nameof(Category))]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(25, MinimumLength = 3)]
        public string Name { get; set; }

        [Required, StringLength(25, MinimumLength = 3)]
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
