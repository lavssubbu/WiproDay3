using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay3Demo
{
    //public access modifier
    public class Customer
    {
        public int custId;
        public string custName;

        public void Display()
        {
            Console.WriteLine($"CustomerId:{custId} \n CustomerName: {custName}");
        }
    }
}
