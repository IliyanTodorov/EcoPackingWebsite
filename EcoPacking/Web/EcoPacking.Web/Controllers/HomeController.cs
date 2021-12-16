namespace EcoPacking.Web.Controllers
{
    using System.Diagnostics;

    using EcoPacking.Services.Data.Contracts;
    using EcoPacking.Web.ViewModels;
    using EcoPacking.Web.ViewModels.Categories;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ICategoriesService categoriesService;

        public HomeController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult Index()
        {
            var viewModel = new CategoriesListViewModel
            {
                Categories = this.categoriesService.GetAll<CategoryInListViewModel>(),
            };

            return this.View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
