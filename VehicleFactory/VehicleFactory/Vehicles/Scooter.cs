using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory.Vehicles
{
    class Scooter : BasicVehicle
    {
        public Scooter(Colors color): base(color)
        {
            Type = VehicleType.Scooter;
            Price = 1500;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Vehicle: {0}, color: {1}, price {2}$", Type, Color, Price);
        }
    }
}
