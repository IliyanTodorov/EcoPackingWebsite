namespace EcoPacking.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using EcoPacking.Data.Common.Models;

    public class DiscountCode : BaseDeletableModel<int>
    {
        public DiscountCode()
        {
            this.Products = new HashSet<Product>();
            this.Orders = new HashSet<Order>();
        }

        [Required]
        public string Name { get; set; }

        public int Percentage { get; set; }

        [ForeignKey(nameof(Cart))]
        public string CartId { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
