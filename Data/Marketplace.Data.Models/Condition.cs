namespace Marketplace.Data.Models
{
    using Common;
    using System.Collections.Generic;

    public class Condition : BaseDeletableModel<int>
    {
        public Condition()
        {
            Ads = new HashSet<Ad>();
        }

        public string Name { get; set; }

        public virtual ICollection<Ad> Ads { get; set; }
    }
}
