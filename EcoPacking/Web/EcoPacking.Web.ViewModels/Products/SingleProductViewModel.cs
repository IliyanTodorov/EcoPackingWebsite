namespace EcoPacking.Web.ViewModels.Products
{
    using System.Linq;

    using AutoMapper;
    using EcoPacking.Data.Models;
    using EcoPacking.Services.Mapping;

    public class SingleProductViewModel : IMapFrom<Product>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Details { get; set; }

        public int AvailableUnits { get; set; }

        public int UnitsPerCase { get; set; }

        public bool AreThereAvailableUnits => this.AvailableUnits > this.UnitsPerCase;

        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Product, SingleProductViewModel>()
                .ForMember(x => x.ImageUrl, opt =>
                    opt.MapFrom(x =>
                        x.Images.FirstOrDefault().RemoteImageUrl != null ?
                        x.Images.FirstOrDefault().RemoteImageUrl :
                        "/images/products/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension));
        }
    }
}
