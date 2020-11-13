namespace EcoPacking.Data.Models
{
    using System.Collections.Generic;

    public class Cart
    {
        public Cart()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public ICollection<Product> Products { get; set; }

        public decimal TotalPrice { get; set; }

        public int DiscountCodeId { get; set; }

        public DiscountCode DiscountCode { get; set; }
    }
}
