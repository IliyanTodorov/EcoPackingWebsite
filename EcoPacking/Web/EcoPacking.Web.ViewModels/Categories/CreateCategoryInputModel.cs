namespace EcoPacking.Web.ViewModels.Categories
{
    using System.ComponentModel.DataAnnotations;

    public class CreateCategoryInputModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
    }
}
