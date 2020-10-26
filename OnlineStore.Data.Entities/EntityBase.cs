using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Data.Entities
{
    public abstract class EntityBase<TKey>
    {
        public TKey Id { get; set; }
    }
}
