namespace Marketplace.Data.Models
{
    using Marketplace.Data.Common;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class User : IdentityUser, IDeletableEntity
    {
        public User()
        {
            UserFavoriteProducts = new HashSet<UserFavoriteProduct>();
            SentBox = new HashSet<Message>();
            Ads = new HashSet<Ad>();
        }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<UserAddress> UserAddresses { get; set; }

        public virtual ICollection<UserFavoriteProduct> UserFavoriteProducts { get; set; }

        public virtual ICollection<Message> Inbox { get; set; }

        public virtual ICollection<Message> SentBox { get; set; }

        public virtual ICollection<Ad> Ads { get; set; }

        public virtual ICollection<Review> OwnedReviews { get; set; }

        public virtual ICollection<Review> CreatedReviews { get; set; }
    }
}
