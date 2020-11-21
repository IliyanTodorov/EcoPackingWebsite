namespace EcoPacking.Web.Areas.Administration.Controllers
{
    using System;
    using System.Threading.Tasks;

    using EcoPacking.Services.Data.Contracts;
    using EcoPacking.Web.ViewModels.Products;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;

    public class ProductsController : AdministrationController
    {
        private readonly IProductsService productsService;
        private readonly ICategoriesService categoriesService;
        private readonly IWebHostEnvironment environment;

        public ProductsController(
            IProductsService productsService,
            ICategoriesService categoriesService,
            IWebHostEnvironment environment)
        {
            this.productsService = productsService;
            this.categoriesService = categoriesService;
            this.environment = environment;
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

            try
            {
                await this.productsService.CreateAsync(input, $"{this.environment.WebRootPath}/images");
            }
            catch (Exception ex)
            {

                this.ModelState.AddModelError(string.Empty, ex.Message);
                return this.View(input);
            }

            return this.Redirect("/");
        }
    }
}
