namespace EcoPacking.Services.Data
{
    using System.Threading.Tasks;

    using EcoPacking.Data.Common.Repositories;
    using EcoPacking.Data.Models;
    using EcoPacking.Services.Data.Contracts;
    using EcoPacking.Web.ViewModels.Products;

    public class ProductsService : IProductsService
    {
        private readonly IDeletableEntityRepository<Product> productsRepository;

        public ProductsService(IDeletableEntityRepository<Product> productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public async Task CreteProduct(CreateProductInputModel input)
        {
            var product = new Product
            {
                Name = input.Name,
                Color = input.Color,
                Size = input.Size,
                UnitPrice = input.UnitPrice,
                UnitsInStock = input.Quantity,
                Details = input.Details,
                CategoryId = input.CategoryId,
            };

            await this.productsRepository.AddAsync(product);
            await this.productsRepository.SaveChangesAsync();
        }
    }
}
