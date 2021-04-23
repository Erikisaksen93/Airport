using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class StorageHold
    {
        public float MaxLoadingWeight { get; private set; }
        public List<Bag> Bags { get; private set; } = new List<Bag>();


        public StorageHold(float maxLoadingWeight)
        {
            MaxLoadingWeight = maxLoadingWeight;
            
        }

    }
}
