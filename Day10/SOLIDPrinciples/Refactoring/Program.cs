// See https://aka.ms/new-console-template for more information
using RefactoringIssues.Models;
using RefactoringIssues.Services;

Console.WriteLine("Hello, World!");

Employee per = new PermanentEmployee("Priya");
Employee temp = new TemporaryEmployee("Shree");
Employee freelancer = new Freelancer("Sid");
Employee intern = new Intern("Navya");

PayrollProcessor payroll = new PayrollProcessor();

payroll.ProcessPayroll(per, 40);
payroll.ProcessPayroll(freelancer, 12);
payroll.ProcessPayroll(intern, 0);

