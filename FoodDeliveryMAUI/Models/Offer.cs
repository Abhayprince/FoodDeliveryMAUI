namespace FoodDeliveryMAUI.Models
{
    public enum OfferType
    {
        Flat,
        Percentage
    }
    public class Offer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        //Coupon Code
        public string Code { get; set; }

        public OfferType OfferType { get; set; }

        // Lets assume teh Value is, 20.
        // if type is Flat -> Flat Rs. 20
        // if the type is Percentage -> 20 %
        public decimal OfferedValue { get; set; }

        public decimal? MinAmount { get; set; } // if null, that means no minimum amount is required

        public DateTime? ValidTill { get; set; } // if null, that means lifetime validity

        public bool IsActive { get; set; }

        public string BgColor { get; set; }

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
        public override string ToString() => $"[Id: {Id}, Name: {Name}]";
    }
}
