namespace EcoPacking.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using EcoPacking.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category { Name = "COFFEE CUPS, LIDS AND ACCESSORIES", });
            await dbContext.Categories.AddAsync(new Category { Name = "HOME DELIVERY & SANDWICH BOXES", });
            await dbContext.Categories.AddAsync(new Category { Name = "SUGARCANE TAKEAWAY CLAMSHELLS", });
            await dbContext.Categories.AddAsync(new Category { Name = "Wraps", });
            await dbContext.Categories.AddAsync(new Category { Name = "Rugs", });
            await dbContext.Categories.AddAsync(new Category { Name = "Towels", });
            await dbContext.Categories.AddAsync(new Category { Name = "Food Takeaway Boxes", });
            await dbContext.Categories.AddAsync(new Category { Name = "Paper", });
            await dbContext.Categories.AddAsync(new Category { Name = "Salad Boxes", });
            await dbContext.Categories.AddAsync(new Category { Name = "Custom Printed Packaging", });
            await dbContext.Categories.AddAsync(new Category { Name = "Bulbs", });
            await dbContext.Categories.AddAsync(new Category { Name = "Napkins", });
            await dbContext.Categories.AddAsync(new Category { Name = "Reusable Straws", });
            await dbContext.Categories.AddAsync(new Category { Name = "Reusable Bags", });
            await dbContext.Categories.AddAsync(new Category { Name = "Reusable Coffee Filters", });

            await dbContext.SaveChangesAsync();
        }
    }
}
