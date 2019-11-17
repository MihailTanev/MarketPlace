namespace Marketplace.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(MarketplaceDbContext dbContext, IServiceProvider serviceProvider);
    }
}
