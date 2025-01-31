using System;

namespace WiproDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of employee 1.Permanent 2.Temporary");
            string? type =Console.ReadLine();

            if (type.ToLower().Contains("per"))
            {
                //  IEmployee employee = new PermanentEmployee() { empid = 111, empname = "Riya", salary = 70000 };
             PermanentEmployee employee = new PermanentEmployee() { empid = 111, empname = "Riya", salary = 70000 };
                employee.BasicDetails();
                employee.SalaryDetails();
                employee.AttendMeetings();
                IEmployee emp = new PermanentEmployee() { empid = 113, empname = "Liya", salary = 80000 };
                emp.BasicDetails();
                emp.SalaryDetails();
              
            }
            else if (type.ToLower().Contains("temp"))
            {
               IEmployee tmp = new TemporaryEmployee()
                {
                    empid = 112,
                    empname = "Riyaz",
                    salaryperday = 7000
                };
                tmp.BasicDetails();
                tmp.SalaryDetails();
            }

        }
    }
}
