namespace EcoPacking.Services.Data
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using EcoPacking.Data.Common.Repositories;
    using EcoPacking.Data.Models;
    using EcoPacking.Services.Data.Contracts;
    using EcoPacking.Web.ViewModels.Products;

    public class ProductsService : IProductsService
    {
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif" };
        private readonly IDeletableEntityRepository<Product> productsRepository;

        public ProductsService(
            IDeletableEntityRepository<Product> productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public async Task CreateAsync(CreateProductInputModel input, string imagePath)
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

            // foreach (var inputVariation in input.Variations)
            // {
            //     product.Variations.Add(new Variation { Name = inputVariation.VariationName, ProductId = product.Id });
            // }

            // /wwwroot/images/products/{id}.{ext}
            Directory.CreateDirectory($"{imagePath}/recipes/");
            foreach (var image in input.Images)
            {
                var extension = Path.GetExtension(image.FileName).TrimStart('.');
                if (!this.allowedExtensions.Any(x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid image extension {extension}");
                }

                var dbImage = new Image
                {
                    Product = product,
                    Extension = extension,
                };
                product.Images.Add(dbImage);

                var physicalPath = $"{imagePath}/Products/{dbImage.Id}.{extension}";
                using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
            }

            await this.productsRepository.AddAsync(product);
            await this.productsRepository.SaveChangesAsync();
        }
    }
}
