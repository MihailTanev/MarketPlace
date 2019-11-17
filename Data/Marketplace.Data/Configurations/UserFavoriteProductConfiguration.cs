namespace Marketplace.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class UserFavoriteProductConfiguration : IEntityTypeConfiguration<UserFavoriteProduct>
    {
        public void Configure(EntityTypeBuilder<UserFavoriteProduct> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
