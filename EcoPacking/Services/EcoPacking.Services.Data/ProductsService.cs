namespace EcoPacking.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using EcoPacking.Data.Common.Repositories;
    using EcoPacking.Data.Models;
    using EcoPacking.Services.Data.Contracts;
    using EcoPacking.Services.Mapping;
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

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12)
        {
            var products = this.productsRepository
                .AllAsNoTrackingWithDeleted()
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .To<T>().ToList();

            return products;
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

            // /wwwroot/images/products/jhdsi-343g3h453-=g34g.jpg
            Directory.CreateDirectory($"{imagePath}/products/");
            foreach (var image in input.Images)
            {
                var extension = Path.GetExtension(image.FileName).TrimStart('.');
                if (!this.allowedExtensions.Any(x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid image extension {extension}");
                }

                var dbImage = new Image
                {
                    ProductId = product.Id,
                    Extension = extension,
                };
                product.Images.Add(dbImage);

                var physicalPath = $"{imagePath}/products/products/{dbImage.Id}.{extension}";
                using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
            }

            await this.productsRepository.AddAsync(product);
            await this.productsRepository.SaveChangesAsync();
        }

        public int GetCount()
        {
            return this.productsRepository.All().Count();
        }

        public T GetById<T>(int id)
        {
            var product = this.productsRepository.All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();

            return product;
        }

        public async Task EditProductAsync(EditProductInputModel input, int id)
        {
            var product = this.productsRepository
                .All()
                .FirstOrDefault(x => x.Id == id);

            product.Name = input.Name;
            product.Details = input.Details;
            product.Price = input.Price;
            product.UnitsPerCase = input.UnitsPerCase;
            product.AvailableUnits = input.AvailableUnits;

            await this.productsRepository.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = this.productsRepository
                .AllWithDeleted()
                .FirstOrDefault(x => x.Id == id);

            this.productsRepository.Delete(product);
            await this.productsRepository.SaveChangesAsync();
        }

        public async Task UnDeleteProduct(int id)
        {
            var product = this.productsRepository
                .AllWithDeleted()
                .FirstOrDefault(x => x.Id == id);

            product.IsDeleted = false;
            product.DeletedOn = null;
            await this.productsRepository.SaveChangesAsync();
        }
    }
}
