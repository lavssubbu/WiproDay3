internal class Program
{
    //delegate refers to a method
    //1.Signature of the delegate should match with the signature of target method
    public delegate void delsample(string msg); //declaring a delegate
    public delegate void delsample2();
    private static void Main(string[] args)
    {
        Program obj = new Program();

        //2.create instance for the delegate - set the target method
        delsample del = new delsample(obj.Display);
        //3.Invoke the delegate
        del("Have a nice day");//calling display method


        delsample2 del2 = new delsample2(Display);
        del2();

        Display();


    }
    //Instance Method
    void Display(string msg)
    {
        Console.WriteLine("Welcome to delegates"+msg);
    }
    //Static method
    static void Display()
    {
        Console.WriteLine("Delegates");
    }
}
