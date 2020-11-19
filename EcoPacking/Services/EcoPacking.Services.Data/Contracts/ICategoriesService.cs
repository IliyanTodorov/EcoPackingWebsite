namespace EcoPacking.Services.Data.Contracts
{
    using System.Threading.Tasks;

    using EcoPacking.Web.ViewModels.Products;

    public interface ICategoriesService
    {
        Task Create(CreateCategoryInputModel input);
    }
}
