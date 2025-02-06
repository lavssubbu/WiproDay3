using RefactoringIssues.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringIssues.Models
{
    public class PermanentEmployee : Employee, IPayable, IPayslipGenerate
    {
        public PermanentEmployee(string name) : base(name) { }

        public override double CalculateSalary(int hoursWorked) => hoursWorked * 50;

        public void ProcessPayment(double salary)
        {
            Console.WriteLine($"Processing Payment for {Name}, Salary: {salary}");
        }

        public void GeneratePaySlip(string employeeName, double salary)
        {
            Console.WriteLine($"Payslip Generated for {employeeName} - Salary: {salary}");
        }
    }
}
