namespace EcoPacking.Web.Controllers
{
    using EcoPacking.Web.ViewModels.Products;
    using Microsoft.AspNetCore.Mvc;

    public class ProductsController : Controller
    {
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(CreateProductInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            return this.Redirect("/");
        }
    }
}
