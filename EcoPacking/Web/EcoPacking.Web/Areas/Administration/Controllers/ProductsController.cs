namespace EcoPacking.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using EcoPacking.Services.Data.Contracts;
    using EcoPacking.Web.ViewModels.Products;
    using Microsoft.AspNetCore.Mvc;

    public class ProductsController : AdministrationController
    {
        private readonly IProductsService productsService;
        private readonly ICategoriesService categoriesService;

        public ProductsController(
            IProductsService productsService,
            ICategoriesService categoriesService)
        {
            this.productsService = productsService;
            this.categoriesService = categoriesService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateProductInputModel();
            viewModel.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateProductInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            await this.productsService.CreateAsync(input);

            return this.Redirect("/");
        }
    }
}
