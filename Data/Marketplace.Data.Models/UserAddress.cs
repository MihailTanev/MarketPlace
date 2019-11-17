namespace Marketplace.Data.Models
{
    public class UserAddress
    {
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}