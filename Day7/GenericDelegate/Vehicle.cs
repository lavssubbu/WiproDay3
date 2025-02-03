using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDel
{
    public class Vehicle
    {
        public virtual Vehicle CreateVehicle() // Covariance: Return derived where base is expected
        {
            Console.WriteLine("Vehicle created");
            return new Vehicle();
        }

        public virtual void Display(Vehicle vehobj) // Contravariance: Accept base parameter where derived is expected
        {
            Console.WriteLine("Vehicle class Method: " + vehobj.GetType().Name);
        }
    }

    class Car : Vehicle
    {
        public override Car CreateVehicle() // Covariance: Returning derived type (Car)
        {
            Console.WriteLine("Car Created");
            return new Car();
        }

        public override void Display(Vehicle vehobj) // Contravariance: Accepting Vehicle (base)
        {
            Console.WriteLine("Car class Method: " + vehobj.GetType().Name);
        }
    }
}
