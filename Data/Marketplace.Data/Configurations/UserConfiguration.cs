
namespace Marketplace.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.UserFavoriteProducts)
                .WithOne(x => x.SellMeUser)
                .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.SentBox)
                .WithOne(x => x.Sender)
                .HasForeignKey(x => x.SenderId);

            builder.HasMany(x => x.Inbox)
                .WithOne(x => x.Recipient)
                .HasForeignKey(x => x.RecipientId);

            builder.HasMany(x => x.Ads)
                .WithOne(x => x.Seller)
                .HasForeignKey(x => x.SellerId);

            builder.HasMany(x => x.OwnedReviews)
                .WithOne(x => x.Owner)
                .HasForeignKey(x => x.OwnerId);

            builder.HasMany(x => x.CreatedReviews)
                .WithOne(x => x.Creator)
                .HasForeignKey(x => x.CreatorId);

        }
    }
}
