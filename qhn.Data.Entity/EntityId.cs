using System;
using System.Collections.Generic;
using System.Text;

namespace qhn.Data.Entity
{
    public abstract class EntityId<T>
    {
        public T Id { get; set; }
    }
}
