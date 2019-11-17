namespace Marketplace.Data
{
    using Marketplace.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class MarketplaceDbContext : IdentityDbContext<User>
    {
        public MarketplaceDbContext(DbContextOptions<MarketplaceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Ad> Ads { get; set; }

        public DbSet<AdView> AdViews { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<UserFavoriteProduct> SellMeUserFavoriteProducts { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Condition> Conditions { get; set; }

        public DbSet<UserAddress> SellMeUserAddresses { get; set; }

        public DbSet<Promotion> Promotions { get; set; }

        public DbSet<PromotionOrder> PromotionOrders { get; set; }

        public DbSet<UpdateAd> UpdateAds { get; set; }

        public DbSet<AdRejection> AdRejections { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseLazyLoadingProxies();
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(MarketplaceDbContext).Assembly);
        }
    }
}
