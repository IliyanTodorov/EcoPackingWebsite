namespace EcoPacking.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using EcoPacking.Data.Models;

    public class ProductsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Products.Any())
            {
                return;
            }

            await dbContext.Products.AddAsync(new Product
            {
                Name = "Brown Vegware Double Wall Coffee Cups",
                Price = 43.32M,
                UnitsPerCase = 500,
                AvailableUnits = 10000,
                Details = $"Brown Double Vegware Wall Coffee Cups, Made from sustainable forest paperboard with a natural PLA cornstarch lining - certified 100 % compostable",
                CategoryId = 1,
            });
            await dbContext.Products.AddAsync(new Product
            {
                Name = "Brown Vegware Double Wall Economy Coffee Cups",
                Price = 36.93M,
                UnitsPerCase = 500,
                AvailableUnits = 10000,
                Details = $"Made from sustainable forest paperboard with a natural PLA cornstarch lining - certified 100% compostable",
                CategoryId = 1,
            });
            await dbContext.Products.AddAsync(new Product
            {
                Name = "Brown Triple Wall Ripple Coffee Cups",
                Price = 34.08M,
                UnitsPerCase = 500,
                AvailableUnits = 10000,
                Details = $"Made from sustainable forest paperboard with a natural PLA cornstarch lining - certified 100% compostable",
                CategoryId = 1,
            });
            await dbContext.Products.AddAsync(new Product
            {
                Name = "Kraft Double Wall Coffee Cups",
                Price = 35.35M,
                UnitsPerCase = 500,
                AvailableUnits = 10000,
                Details = $"Made from sustainable forest paperboard with a natural PLA cornstarch lining - certified 100% compostable",
                CategoryId = 1,
            });
            await dbContext.Products.AddAsync(new Product
            {
                Name = "Art Series Embossed Double Wall Coffee Cups",
                Price = 70.70M,
                UnitsPerCase = 500,
                AvailableUnits = 10000,
                Details = $"Made from sustainable forest paperboard with a natural PLA cornstarch lining - certified 100% compostable PLEASE NOTE THAT THE PRINTED ARTWORK DESIGNS ON THIS RANGE OF “ART SERIES” CUPS WILL DIFFER FROM BATCH TO BATCH AND WILL FEATURE DIFFERENT DESIGNS FROM DIFFERENT ARTISTS ON EACH BATCH PRODUCED. PICTURED HERE ARE EXAMPLES OF DESIGNS FROM THE LAST ART SERIES.",
                CategoryId = 1,
            });
            await dbContext.Products.AddAsync(new Product
            {
                Name = "Home Delivery Box",
                Price = 50.71M,
                UnitsPerCase = 50,
                AvailableUnits = 1000,
                Details = $"Made from sustainable forest paperboard with a natural PLA cornstarch lining - certified 100% compostable",
                CategoryId = 2,
            });
            await dbContext.Products.AddAsync(new Product
            {
                Name = "Kraft Hot Food Carton - Size B / No.8 (45oz / 1300ml)",
                Price = 40.85M,
                UnitsPerCase = 300,
                AvailableUnits = 4000,
                Details = $"Made from sustainable forest paperboard with a natural PLA cornstarch lining - certified 100% compostable",
                CategoryId = 2,
            });
            await dbContext.Products.AddAsync(new Product
            {
                Name = "Kraft Pizza Box With Handle",
                Price = 15.00M,
                UnitsPerCase = 100,
                AvailableUnits = 5000,
                Details = $"Made from sustainably sourced paper - certified 100% compostable",
                CategoryId = 2,
            });
            await dbContext.Products.AddAsync(new Product
            {
                Name = "Kraft Carry Pack",
                Price = 63.35M,
                UnitsPerCase = 125,
                AvailableUnits = 5000,
                Details = $"Made from sustainably sourced paper - certified 100% compostable",
                CategoryId = 2,
            });
            await dbContext.Products.AddAsync(new Product
            {
                Name = "Home Delivery Box Inserts",
                Price = 13.86M,
                UnitsPerCase = 50,
                AvailableUnits = 1000,
                Details = $"Made from sustainably sourced paperboard - certified 100% compostable.",
                CategoryId = 2,
            });
            await dbContext.Products.AddAsync(new Product
            {
                Name = "Sugarcane Square Burger Box",
                Price = 41.77M,
                UnitsPerCase = 500,
                AvailableUnits = 7000,
                Details = $"Made from Bagasse (recycled sugarcane) - certified 100% compostable.",
                CategoryId = 3,
            });
            await dbContext.Products.AddAsync(new Product
            {
                Name = "Sugarcane Rectangular Clamshell Box - Extra Large",
                Price = 35.57M,
                UnitsPerCase = 200,
                AvailableUnits = 3000,
                Details = $"Made from Bagasse (recycled sugarcane) - certified 100% compostable.",
                CategoryId = 3,
            });
            await dbContext.Products.AddAsync(new Product
            {
                Name = "Rectangular Sugarcane Fish & Chip Box - 12 X 6 / 300mm X 150mm",
                Price = 43.72M,
                UnitsPerCase = 250,
                AvailableUnits = 3400,
                Details = $"Made from Bagasse (recycled sugarcane) - certified 100% compostable. Ideal for large fish and chips.",
                CategoryId = 3,
            });
            await dbContext.Products.AddAsync(new Product
            {
                Name = "Size 3 Sugarcane Rectangular Gourmet Container",
                Price = 49.25M,
                UnitsPerCase = 600,
                AvailableUnits = 6300,
                Details = $"Made from Bagasse (recycled sugarcane) - certified 100% compostable. Ideal for large fish and chips.",
                CategoryId = 3,
            });
        }
    }
}
