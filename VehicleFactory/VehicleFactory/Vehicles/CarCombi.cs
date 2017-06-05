using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory.Vehicles
{
    public class CarCombi: BasicVehicle
    {
        public CarCombi(Colors color): base(color)
        {
            Type = VehicleType.Car_Combi;
            Price = 80000;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Vehicle: {0}, color: {1}, price {2}$", Type, Color, Price);
        }
    }
}
