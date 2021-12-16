namespace EcoPacking.Web.ViewModels.Categories
{
    using EcoPacking.Data.Models;
    using EcoPacking.Services.Mapping;

    public class CategoryInListViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
