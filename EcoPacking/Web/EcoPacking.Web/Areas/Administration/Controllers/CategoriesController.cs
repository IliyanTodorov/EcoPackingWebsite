namespace EcoPacking.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using EcoPacking.Services.Data;
    using EcoPacking.Services.Data.Contracts;
    using EcoPacking.Web.ViewModels.Categories;
    using Microsoft.AspNetCore.Mvc;

    public class CategoriesController : AdministrationController
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult Add()
        {
            return this.View();
        }

        public async Task<IActionResult> AddAsync(CreateCategoryInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.categoriesService.AddAsync(input);

            return this.Redirect("/");
        }
    }
}
