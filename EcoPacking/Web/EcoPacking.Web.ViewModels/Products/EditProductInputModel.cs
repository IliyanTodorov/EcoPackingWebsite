namespace EcoPacking.Web.ViewModels.Products
{
    using System.ComponentModel.DataAnnotations;

    using EcoPacking.Data.Models;
    using EcoPacking.Services.Mapping;

    public class EditProductInputModel : IMapTo<Product>
    {
        [Required]
        [MinLength(4)]
        [MaxLength(60)]
        public string Name { get; set; }

        [Required]
        [MinLength(15)]
        public string Details { get; set; }

        [Range(0, 1000)]
        public decimal Price { get; set; }

        [Range(1, 5000)]
        public int UnitsPerCase { get; set; }

        public int AvailableUnits { get; set; }

        public bool IsAvailable => this.AvailableUnits > 0;
    }
}
