namespace EcoPacking.Web.ViewModels.Products
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EcoPacking.Data.Models;
    using EcoPacking.Services.Mapping;
    using Microsoft.AspNetCore.Http;

    public class CreateProductInputModel : IMapTo<Product>
    {
        
        public IEnumerable<IFormFile> Images { get; set; }

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

        public int CategoryId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }

        public IEnumerable<ProductVariationInputModel> Variations { get; set; }
    }
}
