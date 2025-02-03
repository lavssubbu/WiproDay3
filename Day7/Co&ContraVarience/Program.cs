// See https://aka.ms/new-console-template for more information
using CoVarience_ContraVarience;

delegate Vehicle delveh();//created delegate returning Vehicle as teurn type
delegate void delcontra(Car car);
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Vehicle vhl = new Vehicle();
        delveh delv = new delveh(vhl.CreateVehicle);

        Car cr = new Car();
        //Covarience - accepting derived class as return type where base class is expected
        delv = new delveh(cr.CreateCar);//accepted

        //contravariance - Display methd with base class parameter is accepted where derived class parameter is expected
        delcontra delcont = new delcontra(vhl.Display);
        delcont.Invoke(cr);

        delcont += cr.DisplayCar;

    }
}


