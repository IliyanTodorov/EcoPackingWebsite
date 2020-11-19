namespace EcoPacking.Web.ViewModels.Products
{
    using System.ComponentModel.DataAnnotations;

    public class CreateCategoryInputModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
    }
}
