namespace Marketplace.Data.Models
{
    using Marketplace.Data.Common;

    public class UserFavoriteProduct : BaseDeletableModel<int>
    {
        public int AdId { get; set; }
        public virtual Ad Ad { get; set; }

        public string UserId { get; set; }
        public virtual User SellMeUser { get; set; }
    }
}