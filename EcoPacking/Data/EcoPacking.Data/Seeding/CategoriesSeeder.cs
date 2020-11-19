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

            await dbContext.Categories.AddAsync(new Category { Name = "Cups", });
            await dbContext.Categories.AddAsync(new Category { Name = "Bottles", });
            await dbContext.Categories.AddAsync(new Category { Name = "Packs", });
            await dbContext.Categories.AddAsync(new Category { Name = "Wraps", });
            await dbContext.Categories.AddAsync(new Category { Name = "Rugs", });
            await dbContext.Categories.AddAsync(new Category { Name = "Towels", });
            await dbContext.Categories.AddAsync(new Category { Name = "Paper", });
            await dbContext.Categories.AddAsync(new Category { Name = "Paper", });
            await dbContext.Categories.AddAsync(new Category { Name = "Bulbs", });

            await dbContext.SaveChangesAsync();
        }
    }
}
