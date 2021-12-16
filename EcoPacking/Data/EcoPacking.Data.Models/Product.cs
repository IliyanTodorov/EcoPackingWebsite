namespace EcoPacking.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using EcoPacking.Data.Common.Models;

    public class Product : BaseDeletableModel<int>
    {
        public Product()
        {
            this.Images = new HashSet<Image>();
            this.Reviews = new HashSet<Review>();
        }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int UnitsPerCase { get; set; }

        public int AvailableUnits { get; set; }

        [Required]
        [MinLength(20)]
        public string Details { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [ForeignKey(nameof(DiscountCode))]
        public int? DiscountCodeId { get; set; }

        public virtual DiscountCode DiscountCode { get; set; }

        [ForeignKey(nameof(Cart))]
        public int? CartId { get; set; }

        public virtual Cart Cart { get; set; }

        [ForeignKey(nameof(Order))]
        public string OrderId { get; set; }

        public virtual Order Order { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
