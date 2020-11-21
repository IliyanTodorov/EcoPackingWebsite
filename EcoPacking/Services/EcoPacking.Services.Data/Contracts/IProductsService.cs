namespace EcoPacking.Services.Data.Contracts
{
    using System.Threading.Tasks;

    using EcoPacking.Web.ViewModels.Products;

    public interface IProductsService
    {
        Task CreateAsync(CreateProductInputModel input, string imagePath);
    }
}
