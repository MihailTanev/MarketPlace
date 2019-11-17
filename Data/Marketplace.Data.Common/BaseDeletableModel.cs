using System;
using System.Collections.Generic;
using System.Text;

namespace Marketplace.Data.Common
{
    public class BaseDeletableModel<TKey> : BaseModel<TKey>, IDeletableEntity
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
