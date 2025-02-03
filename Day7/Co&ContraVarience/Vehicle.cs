using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoVarience_ContraVarience
{
    internal class Vehicle
    {
        //covarience - Output type variance(return type) - accepts the derived class where base class is expected
        public Vehicle CreateVehicle()
        {
            Console.WriteLine("Vehicle created");
            return new Vehicle();
        }
        //contravarience - input type variance(parameter) - accpets base class parameter where derived class is expected
        public void Display(Vehicle vehobj)
        {
            Console.WriteLine("Vehicles class Method" + vehobj);
        }

    }
    class Car : Vehicle
    {
        public Car CreateCar()
        {
            Console.WriteLine("Car Created");
            return new Car();
        }
        public void DisplayCar(Car carobj)
        {
            Console.WriteLine("Car class Method" + carobj);
        }
    }
}
