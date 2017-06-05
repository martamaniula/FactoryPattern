using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleFactory.Vehicles;

namespace VehicleFactory
{
    public class Factory
    {
        public BasicVehicle CreateVehicle(Order order)
        {
            if (order.Type == VehicleType.Car_Standard)
                return new CarStandard(order.Color);
            else if (order.Type == VehicleType.Car_Combi)
                return new CarCombi(order.Color);
            else return new Scooter(order.Color);
        }
    }
}
