namespace WiproDay3Demo
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the ProductId");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ProductName");
           string nm = Console.ReadLine();

            Product product = new Product(id,nm); // object creation - calling parameterized constructor
            product.PublicMthd();
            

            Customer cust = new Customer();
            Console.WriteLine("Enter the CustomerId");
            cust.custId = Convert.ToInt32(Console.ReadLine()); //assigning the user input to the class member directly since it is public
            Console.WriteLine("Enter the CustomerName");
            cust.custName = Console.ReadLine();

            cust.Display();
        }
    }
}