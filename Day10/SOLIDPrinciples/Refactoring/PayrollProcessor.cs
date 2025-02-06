using RefactoringIssues.Interfaces;
using RefactoringIssues.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringIssues.Services
{
    public class PayrollProcessor
    {
        public void ProcessPayroll(Employee employee, int hoursWorked)
        {
            double salary = employee.CalculateSalary(hoursWorked);

            if (employee is IPayable payable)
            {
                payable.ProcessPayment(salary);
            }

            if (employee is IPayslipGenerate payslipGenerator)
            {
                payslipGenerator.GeneratePaySlip(employee.Name, salary);
            }
        }
    }
}
