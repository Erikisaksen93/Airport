using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class Bag
    {
        public float Weight { get; private set; }
        public string TagId { get; private set; } = BagIdGenerator.Generate(2, 10);

        public Bag(float weight)
        {
            Weight = weight;
        }

    }
}
