using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory.Vehicles
{
    public class CarStandard : BasicVehicle
    {
        public CarStandard(Colors color): base(color)
        {
            Type = VehicleType.Car_Standard;
            Price = 30000;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Vehicle: {0}, color: {1}, price {2}$", Type, Color, Price);
        }
    }
}
