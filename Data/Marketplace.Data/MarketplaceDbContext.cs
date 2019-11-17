namespace Marketplace.Data
{
    using Marketplace.Data.Configurations;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new AdRejectionConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ConditionConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionsOrderConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
            modelBuilder.ApplyConfiguration(new SubCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new UpdateAdConfiguration());
            modelBuilder.ApplyConfiguration(new UserAddressConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserFavoriteProductConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
