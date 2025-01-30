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

        //calling base class constructor
        public Manager(int eid,string ename,string dname,decimal sal,string ManagerName) :base(eid,ename,dname,sal)
        {
            this.ManagerName = ManagerName;
        }

        public override void Display()
        {
           base.Display(); //call display method of department class
            Console.WriteLine("Manager Name" + ManagerName);
        }
    }
}
