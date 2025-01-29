using WiproDay3Demo;

namespace AccessSpecifierdemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Customer cst = new Customer();
            cst.custId = 11;
            cst.custName = "Liya";
            cst.Display();
        }
    }
}