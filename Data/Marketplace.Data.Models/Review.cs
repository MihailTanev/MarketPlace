namespace Marketplace.Data.Models
{
    using Common;

    public class Review : BaseDeletableModel<int>
    {
        public int Rating { get; set; }

        public string Comment { get; set; }

        public string OwnerId { get; set; }
        public virtual User Owner { get; set; }

        public string CreatorId { get; set; }
        public virtual User Creator { get; set; }
    }
}
