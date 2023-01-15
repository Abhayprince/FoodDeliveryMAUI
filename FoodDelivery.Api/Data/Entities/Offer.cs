using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Api.Data.Entities
{
    [Table(nameof(Offer))]
    public class Offer
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50, MinimumLength = 10)]
        public string Name { get; set; }

        [Required, StringLength(25, MinimumLength = 3)]
        public string Image { get; set; }

        [MaxLength(250)]
        public string? Description { get; set; }

        [Required, StringLength(10, MinimumLength = 3)]
        public string Code { get; set; }//Coupon Code

        public OfferType OfferType { get; set; }

        // Lets assume teh Value is, 20.
        // if type is Flat -> Flat Rs. 20
        // if the type is Percentage -> 20 %
        public decimal OfferedValue { get; set; }

        public decimal? MinAmount { get; set; } // if null, that means no minimum amount is required

        public DateTime? ValidTill { get; set; } // if null, that means lifetime validity

        public bool IsActive { get; set; }

        [MaxLength(15)]
        public string? BgColor { get; set; }

        public Offer(int id, string name, string image, string description, string code, OfferType offerType, decimal offeredValue, decimal? minAmount, DateTime? validTill, string bgColor = "Red")
        {
            Id = id;
            Name = name;
            Image = image;
            Description = description;
            Code = code;
            OfferType = offerType;
            OfferedValue = offeredValue;
            MinAmount = minAmount;
            ValidTill = validTill;
            IsActive = true;
            BgColor = bgColor;
        }
        public Offer()
        {
        }
    }
}
