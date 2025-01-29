using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodStaticDemo
{
    internal class Employee
    {
        //attributes/properties/data members
        public int EmpId {  get; set; }
        public string EmpName {  get; set; }
        public string Dept { get; set; }
        public decimal Salary { get; set; }
        //Constructor
        public Employee(int EmpId,string EmpName,string Dept,decimal Salary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.Dept = Dept;
            this.Salary = Salary;
        }
        //Methods
        public void Display()
        {
            Console.WriteLine("EmployeeDetails:");
            Console.WriteLine($"EmployeeID:{EmpId} EmployeeName:{EmpName} Department:{Dept} Salary:{Salary}");
        }
    }
}
