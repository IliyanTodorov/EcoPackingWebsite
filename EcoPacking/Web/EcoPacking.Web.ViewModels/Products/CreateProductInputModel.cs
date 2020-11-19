namespace EcoPacking.Web.ViewModels.Products
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class CreateProductInputModel
    {
        [Required]
        [MinLength(4)]
        [MaxLength(60)]
        public string Name { get; set; }

        [MinLength(3)]
        public string Color { get; set; }

        public string Size { get; set; }

        [Required]
        [MinLength(15)]
        public string Details { get; set; }

        [Range(0, 1000)]
        public decimal UnitPrice { get; set; }

        [Range(1, 5000)]
        public int Quantity { get; set; }

        public bool IsAvailable => this.Quantity > 0;

        public int CategoryId { get; set; }
    }
}
