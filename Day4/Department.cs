using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproOOPSconcepts
{
    internal class Department : Employee // Inheritance - Department is derived from the base class Employee
    {
        public string DeptName { get; set; }
        public decimal Salary {  get; set; }

        //public void show()
        //{
        //    Console.WriteLine(DeptName + " " + Salary);
        //}
        public override void Display()
        {
            base.Display();//control goes to the base class(Employee) display method
            Console.WriteLine(DeptName + " " + Salary);
        }
    }
}
