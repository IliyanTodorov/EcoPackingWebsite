namespace EcoPacking.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using EcoPacking.Data.Common.Models;

    public class Cart : BaseDeletableModel<int>
    {
        public Cart()
        {
            this.Products = new HashSet<Product>();
        }

        [ForeignKey(nameof(DiscountCode))]
        public int? DiscountCodeId { get; set; }

        public virtual DiscountCode DiscountCode { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
