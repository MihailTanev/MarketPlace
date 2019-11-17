namespace Marketplace.Data.Models
{
    using Common;

    public class AdView : BaseDeletableModel<int>
    {
        public int AdId { get; set; }

        public virtual Ad Ad { get; set; }
    }
}
