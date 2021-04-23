using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class Aircraft
    {
        public StorageHold StorageHoldOne;
        public StorageHold StorageHoldTwo;


        public Aircraft(StorageHold storageHoldOne, StorageHold storageHoldTwo)
        {
            StorageHoldOne = storageHoldOne;
            StorageHoldTwo = storageHoldTwo;
        }
    }
}
