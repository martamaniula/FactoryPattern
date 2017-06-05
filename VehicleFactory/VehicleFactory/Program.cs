using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleFactory.Vehicles;

namespace VehicleFactory
{
    public enum VehicleType
    {
        Car_Standard,
        Car_Combi,
        Scooter
    }

    public enum Colors
    {
        Green,
        Blue,
        Purple
    }
    class Program
    {
        static void Main(string[] args)
        {

            Factory MyFactory = new Factory();

            List<Order> Orders = new List<Order>();
            Orders.Add(new Order(Colors.Green, VehicleType.Car_Combi));
            Orders.Add(new Order(Colors.Purple, VehicleType.Scooter));
            Orders.Add(new Order(Colors.Blue, VehicleType.Car_Standard));

            foreach (var order in Orders)
            {
                MyFactory.CreateVehicle(order).GetInfo();

            }


        }
    }
}
