namespace EcoPacking.Web.ViewComponents
{
    using System.Linq;

    using EcoPacking.Data.Common.Repositories;
    using EcoPacking.Data.Models;
    using EcoPacking.Services.Mapping;
    using EcoPacking.Web.ViewModels.Products;
    using Microsoft.AspNetCore.Mvc;

    public class ProductsListViewComponent : ViewComponent
    {
        private readonly IDeletableEntityRepository<Product> productsRepository;

        public ProductsListViewComponent(
            IDeletableEntityRepository<Product> productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public IViewComponentResult Invoke()
        {
            var model = new ProductsListViewModel
            {
                Products = this.productsRepository
                .AllAsNoTracking()
                .OrderByDescending(x => x.CreatedOn)
                //.Select(x => new ProductInListViewModel
                //{
                //    Id = x.Id,
                //    Name = x.Name,
                //    CategoryId = x.CategoryId,
                //    ImageUrl =
                //        x.Images.FirstOrDefault().RemoteImageUrl != null ?
                //        x.Images.FirstOrDefault().RemoteImageUrl :
                //        "/images/products/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension,
                //})
                .To<ProductInListViewModel>()
                .ToList(),
            };

            return this.View(model);
        }
    }
}
