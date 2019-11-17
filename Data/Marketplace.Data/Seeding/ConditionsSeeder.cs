namespace Marketplace.Data.Seeding
{
    using System;
    using System.Threading.Tasks;
    using Marketplace.Common;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class ConditionsSeeder : ISeeder
    {
        public async Task SeedAsync(MarketplaceDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (await dbContext.Conditions.AnyAsync())
            {
                return;
            }

            await dbContext.AddAsync(new Condition
            { Name = GlobalConstants.ConditionBrandNewName, CreatedOn = DateTime.UtcNow });
            await dbContext.AddAsync(new Condition
            { Name = GlobalConstants.ConditionUsedName, CreatedOn = DateTime.UtcNow });
        }
    }
}
