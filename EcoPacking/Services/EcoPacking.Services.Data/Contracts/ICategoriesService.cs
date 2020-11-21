namespace EcoPacking.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using EcoPacking.Web.ViewModels.Categories;

    public interface ICategoriesService
    {
        Task AddAsync(CreateCategoryInputModel input);

        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();

        IEnumerable<T> GetAll<T>();
    }
}
