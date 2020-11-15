namespace EcoPacking.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using EcoPacking.Data.Common.Models;

    public class Order : BaseDeletableModel<string>
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Products = new HashSet<Product>();
        }

        public DateTime OrderDate { get; set; }

        public DateTime ShipDate { get; set; }

        public virtual OrderStatus OrderStatus { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public decimal GrandTotal { get; set; }

        [Required]
        [ForeignKey(nameof(Customer))]
        public string CustomerId { get; set; }

        public virtual ApplicationUser Customer { get; set; }

        [ForeignKey(nameof(DiscountCode))]
        public int? DiscountCodeId { get; set; }

        public virtual DiscountCode DiscountCode { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
