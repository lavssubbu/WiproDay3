using SampleAbstractcls;

internal class Program
{
    private static void Main(string[] args)
    {
        //Abstract class cannot be instantiated
        //It is not mandatory to have abstract method in abstract class.
        //Generally,we go for abstract in order to show essential features and hide mthd impl
        // Flight fli = new Flight();
        //Object Initializer - At the time of object creation,initialize the values
        FlightFare flightFare = new FlightFare() { FlightNo = 11, FlightName = "AirIndia", durationinhrs = 6, typedes = "International" };
        flightFare.FlightDetails();
        flightFare.FareDetails();

        //create instance for FlightFare by making as a reference to Flight which is abstract class
        Flight ff = new FlightFare() { FlightNo = 12, FlightName = "Spicejet", durationinhrs = 3, typedes = "National" };
        ff.FlightDetails();
        ff.FareDetails();
    }
}