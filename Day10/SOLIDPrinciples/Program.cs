// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
public interface IEmployee//violating interface segregation
{
    void CalculateSalary(int hoursWorked);
    void ProcessPayment();
    void GeneratePaySlip();
}

public class Employee : IEmployee //violating single responsibility
{
    public string Name { get; set; }
    public string EmployeeType { get; set; }

    public Employee(string name, string type)
    {
        Name = name;
        EmployeeType = type;
    }

    public void CalculateSalary(int hoursWorked)
    {
        if (EmployeeType == "FullTime")
        {
            Console.WriteLine($"{Name} (Full-Time) Salary: {hoursWorked * 50}");
        }
        else if (EmployeeType == "PartTime")
        {
            Console.WriteLine($"{Name} (Part-Time) Salary: {hoursWorked * 30}");
        }
        else if (EmployeeType == "Freelancer")
        {
            Console.WriteLine($"{Name} (Freelancer) Payment Per Task: {hoursWorked * 20}");
        }
        else
        {
            throw new Exception("Invalid Employee Type");
        }
    }

    public void ProcessPayment()
    {
        Console.WriteLine($"Processing Payment for {Name}");
    }

    public void GeneratePaySlip()
    {
        string paySlip = $"Payslip for {Name}";
        File.WriteAllText($"{Name}_Payslip.txt", paySlip);
        Console.WriteLine("Payslip Generated");
    }
}
public class Intern : Employee
{
    public Intern(string name) : base(name, "Intern") { }

    public new void CalculateSalary(int hoursWorked)
    {
        Console.WriteLine($"{Name} (Intern) has no salary.");
    }
}

public class PayrollProcessor //tightly coupled violating DIP
{
    public void ProcessPayroll(Employee employee, int hoursWorked)
    {
        employee.CalculateSalary(hoursWorked);
        employee.ProcessPayment();
        employee.GeneratePaySlip();
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee("Alice", "FullTime");
        Employee emp2 = new Employee("Bob", "PartTime");
        Employee emp3 = new Employee("Charlie", "Freelancer");
        Intern emp4 = new Intern("David");

        PayrollProcessor processor = new PayrollProcessor();
        processor.ProcessPayroll(emp1, 40);
        processor.ProcessPayroll(emp2, 20);
        processor.ProcessPayroll(emp3, 10);
        processor.ProcessPayroll(emp4, 0);
    }
}
