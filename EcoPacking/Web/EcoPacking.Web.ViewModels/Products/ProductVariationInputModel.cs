namespace EcoPacking.Web.ViewModels.Products
{
    using System.ComponentModel.DataAnnotations;

    public class ProductVariationInputModel
    {
        [Required]
        [MinLength(3)]
        public string VariationName { get; set; }
    }
}
