using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestDemo
{
    public class EmployeeCla
    {
        public string Name { get; set; }
        public string EmployeeID { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public EmployeeCla(string name, string employeeID, string department, decimal salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Department = department;
            Salary = salary;
        }
    }

    public class EmployeeManager
    {
        private List<EmployeeCla> Employees = new List<EmployeeCla>();

        public void AddEmployee(EmployeeCla employee)
        {
            Employees.Add(employee);
        }

        public bool UpdateEmployee(string employeeID, string department, decimal salary)
        {
            var employee = Employees.FirstOrDefault(e => e.EmployeeID == employeeID);
            if (employee == null)
                return false;

            employee.Department = department;
            employee.Salary = salary;
            return true;
        }

        public bool RemoveEmployee(string employeeID)
        {
            var employee = Employees.FirstOrDefault(e => e.EmployeeID == employeeID);
            if (employee == null)
                return false;

            Employees.Remove(employee);
            return true;
        }

        public List<EmployeeCla> ViewEmployees()
        {
            return Employees;
        }

        public EmployeeCla SearchEmployee(string employeeID)
        {
            return Employees.FirstOrDefault(e => e.EmployeeID == employeeID);
        }
    }

}
