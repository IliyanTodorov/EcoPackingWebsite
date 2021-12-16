namespace EcoPacking.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using EcoPacking.Web.ViewModels.Products;

    public interface IProductsService
    {
        Task CreateAsync(CreateProductInputModel input, string imagePath);

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        int GetCount();

        T GetById<T>(int id);

        Task EditProductAsync(EditProductInputModel input, int id);

        Task DeleteProduct(int id);

        Task UnDeleteProduct(int id);
    }
}
