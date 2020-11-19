namespace EcoPacking.Web.Controllers
{
    using System.Threading.Tasks;

    using EcoPacking.Services.Data;
    using EcoPacking.Web.ViewModels.Products;
    using Microsoft.AspNetCore.Mvc;

    public class ProductsController : Controller
    {
        private readonly ProductsService productsService;
        private readonly CategoriesService categoriesService;

        public ProductsController(ProductsService productsService, CategoriesService categoriesService)
        {
            this.productsService = productsService;
            this.categoriesService = categoriesService;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.productsService.CreteProduct(input);

            return this.Redirect("/");
        }

        public IActionResult CreateCategory()
        {
            return this.View();
        }

        public async Task<IActionResult> CreateCategory(CreateCategoryInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.categoriesService.Create(input);

            return this.Redirect("/");
        }
    }
}
