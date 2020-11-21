namespace EcoPacking.Services.Data
{
    using System.Linq;
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

        public async Task CreateAsync(CreateProductInputModel input)
        {
            var product = new Product
            {
                Name = input.Name,
                Price = input.Price,
                UnitsPerCase = input.UnitsPerCase,
                AvailableUnits = input.AvailableUnits,
                Details = input.Details,
                CategoryId = input.CategoryId,
            };

            foreach (var inputVariation in input.Variations)
            {
                product.Variations.Add(new Variation { Name = inputVariation.VariationName, ProductId = product.Id });
            }

            await this.productsRepository.AddAsync(product);
            await this.productsRepository.SaveChangesAsync();
        }
    }
}
