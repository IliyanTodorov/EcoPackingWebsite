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
                await this.productsService.CreateAsync(input, $"{this.environment.WebRootPath}/images/Products");
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                return this.View(input);
            }

            return this.Redirect("/");
        }

        public IActionResult Edit(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 9;
            var productsViewModel = new ProductsListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                ProductsCount = this.productsService.GetCount(),
                Products = this.productsService.GetAll<ProductInListViewModel>(id, ItemsPerPage),
            };

            return this.View(productsViewModel);
        }

        public IActionResult EditProduct(int id)
        {
            var viewModel = this.productsService.GetById<SingleProductViewModel>(id);

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditProduct(EditProductInputModel input, int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.productsService.EditProductAsync(input, id);

            return this.RedirectToAction(nameof(this.Success));
        }

        public IActionResult Success()
        {
            return this.View();
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            await this.productsService.DeleteProduct(id);

            return this.RedirectToAction(nameof(this.Edit));
        }

        public async Task<IActionResult> UnDeleteProduct(int id)
        {
            await this.productsService.UnDeleteProduct(id);

            return this.RedirectToAction(nameof(this.Edit));
        }
    }
}
