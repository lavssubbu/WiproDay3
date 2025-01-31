internal class Program
{
    //static class only supports method overloading(compile time polymorphism) and method overriding(run time polymorphism)
    static class MathHelper //efficient for utility functions - static members & static functions
    {
        public static int count=0;//static field
        public static double square(double num)
        {
            return num * num;
        }
        public static double square(int num)
        {
            return num * num;
        }
        public static double Cube(double num)
        {
            return num * num * num;
        }
        public static void Dsiplay()
        {
            count++;
            Console.WriteLine(count);
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(MathHelper.square(10));
        MathHelper.Dsiplay();        

    }
}