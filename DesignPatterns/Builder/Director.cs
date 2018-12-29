using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    /// The 'Director' class
    class Shop
    {
        // Builder uses a complex series of steps

        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
