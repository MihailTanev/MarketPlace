namespace Marketplace.Data.Models
{
    using Marketplace.Data.Common;
    using System.Collections.Generic;

    public class Address : BaseDeletableModel<int>
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string District { get; set; }

        public int ZipCode { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public virtual ICollection<UserAddress> UserAddresses { get; set; }

        public virtual ICollection<Ad> Ads { get; set; }
    }
}
