using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringIssues.Models
{
    public class Intern : Employee
    {
        public Intern(string name) : base(name) { }

        public override double CalculateSalary(int hoursWorked)
        {
            Console.WriteLine($"{Name} (Intern) has no salary.");
            return 0;
        }
    }
}
