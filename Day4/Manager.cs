using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproOOPSconcepts
{
    internal class Manager : Department
    {
        public string ManagerName { get; set; }

        public override void Display()
        {
           base.Display(); //call display method of department class
            Console.WriteLine("Manager Name" + ManagerName);
        }
    }
}
