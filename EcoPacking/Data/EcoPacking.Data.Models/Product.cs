namespace EcoPacking.Data.Models
{
    using EcoPacking.Data.Common.Models;

    public class Product : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public decimal Price { get; set; }

        public string Details { get; set; }

        public int DiscountCodeId { get; set; }

        public DiscountCode DiscountCode { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
