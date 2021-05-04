using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public abstract class EntityBase
    {
        public enum EntityStateOption
        { 
            Active,
            Deleted
        }
        public EntityStateOption EntityState { get; set; }
        public bool isNew { get; private set; }
        public bool hasChanges { get; set; }
        public bool isValid => Validate();

        public abstract bool Validate();

    }
}
