using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory.Vehicles
{
    
    public abstract class BasicVehicle
    {
        public BasicVehicle(Colors color)
        {
            Color = color;
        }

        public VehicleType Type;

        public Colors Color;

        public double Price;

        public abstract void GetInfo();
    }
}
