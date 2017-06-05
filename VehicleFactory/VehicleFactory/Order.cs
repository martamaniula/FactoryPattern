using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory.Vehicles
{
    public class Order
    {
        public Colors Color { get; private set; }

        public VehicleType Type { get; private set; }

        public Order(Colors color, VehicleType type)
        {
            Color = color;
            Type = type;
        }

    }
}
