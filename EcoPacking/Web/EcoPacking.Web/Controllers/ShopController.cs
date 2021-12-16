namespace EcoPacking.Web.Controllers
{
    using EcoPacking.Services.Data.Contracts;
    using EcoPacking.Web.ViewModels.Categories;
    using EcoPacking.Web.ViewModels.Products;
    using EcoPacking.Web.ViewModels.Shop;
    using Microsoft.AspNetCore.Mvc;

    public class ShopController : BaseController
    {
        private readonly IProductsService productsService;
        private readonly ICategoriesService categoriesService;

        public ShopController(
            IProductsService productsService,
            ICategoriesService categoriesService)
        {
            this.productsService = productsService;
            this.categoriesService = categoriesService;
        }

        public IActionResult Index(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 9;
            //var productsViewModel = new ProductsListViewModel
            //{
            //    ItemsPerPage = ItemsPerPage,
            //    PageNumber = id,
            //    ProductsCount = this.productsService.GetCount(),
            //    Products = this.productsService.GetAll<ProductInListViewModel>(id, ItemsPerPage),
            //};
            var categoriesViewModel = new CategoriesListViewModel
            {
                Categories = this.categoriesService.GetAll<CategoryInListViewModel>(),
            };
            var viewModel = new ShopIndexViewModel
            {
                //Products = productsViewModel,
                Categories = categoriesViewModel,
            };

            return this.View("ShopIndex", viewModel);
        }

        public IActionResult ById(int id)
        {
            var product = this.productsService.GetById<SingleProductViewModel>(id);

            return this.View("ProductById", product);
        }
    }
}
