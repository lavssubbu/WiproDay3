using RefactoringIssues.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringIssues.Models
{
    public abstract class Employee : ISalaryCalculate
    {
        public string Name { get; set; }
        public abstract double CalculateSalary(int hoursWorked);

        protected Employee(string name)
        {
            Name = name;
        }
    }
}
