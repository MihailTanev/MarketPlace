namespace Marketplace.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class UserAddressConfiguration : IEntityTypeConfiguration<UserAddress>
    {
        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.HasKey(x => new { x.AddressId, x.UserId });

            builder.HasOne(x => x.User)
                .WithMany(x => x.UserAddresses)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Address)
                .WithMany(x => x.UserAddresses)
                .HasForeignKey(x => x.AddressId);
        }
    }
}
