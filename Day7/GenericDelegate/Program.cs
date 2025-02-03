class Program
{
    // Delegate combining Covariance (out) & Contravariance (in)
    //Generic Delegate
    delegate TOutput CovariantContravariantDelegate<in TInput, out TOutput>(TInput input);

    static Vehicle ProcessVehicle(Vehicle v) // Covariance & Contravariance Example
    {
        Console.WriteLine("Processing: " + v.GetType().Name);
        return new Car(); // Covariance (Returning derived type)
    }

    static void Main()
    {
        // Delegate where input is Car (contravariant) and return is Vehicle (covariant)
        CovariantContravariantDelegate<Car, Vehicle> handler = ProcessVehicle;

        Car myCar = new Car();
        Vehicle result = handler(myCar); // Passing Car (contravariance), getting Vehicle (covariance)

        Console.WriteLine("Returned: " + result.GetType().Name);
    }
}
