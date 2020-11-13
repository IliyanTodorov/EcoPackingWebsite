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

        [Required]
        [MinLength(15)]
        public string Description { get; set; }

        [DisplayName("Additianal Information")]
        public string AdditionalInformation { get; set; }

        [Range(0, 1000)]
        public decimal Price { get; set; }

        public ICollection<string> Sizes { get; set; }

        [Range(1, 5000)]
        public int Quantity { get; set; }

        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }
    }
}
