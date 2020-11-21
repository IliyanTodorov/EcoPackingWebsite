namespace EcoPacking.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using EcoPacking.Data.Common.Repositories;
    using EcoPacking.Data.Models;
    using EcoPacking.Services.Data.Contracts;
    using EcoPacking.Services.Mapping;
    using EcoPacking.Web.ViewModels.Categories;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public async Task AddAsync(CreateCategoryInputModel input)
        {
            var category = new Category
            {
                Name = input.Name,
            };

            await this.categoriesRepository.AddAsync(category);
            await this.categoriesRepository.SaveChangesAsync();
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.categoriesRepository.AllAsNoTracking()
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                })
                .OrderBy(x => x.Name)
                .ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }

        public IEnumerable<T> GetAll<T>()
        {
            var categories = this.categoriesRepository.AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .To<T>()
                .ToList();

            return categories;
        }
    }
}
