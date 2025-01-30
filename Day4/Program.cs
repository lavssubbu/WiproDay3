namespace WiproOOPSconcepts
{
    class Program
    {
        static void Main(string[] args)
        {
          // Employee emp = new Employee();
          //  emp.Empid = 11;
          //  emp.EmpName = "Test";

          ////  emp.Display();

          //  Department dpt = new Department(); //creating instance for the derived class
          //  dpt.Empid = 111;
          //  dpt.EmpName = "Priya";
          //  dpt.DeptName = "Develoepr";
          //  dpt.Salary = 50000;

            //dpt.Display();
          //  dpt.Show();

          //  Manager mgr = new Manager();
            //mgr.Empid = 111;
            //mgr.EmpName = "Priya";
            //mgr.DeptName = "Develoepr";
            //mgr.Salary = 50000;
            //mgr.ManagerName = "Riyaz";
            //mgr.Display();
            int id = Convert.ToInt32(Console.ReadLine());
            string name=Console.ReadLine();
            string dname = Console.ReadLine();
            decimal sal = Convert.ToDecimal(Console.ReadLine());
            string mname = Console.ReadLine();
            Manager mgrcon = new Manager(id,name,dname,sal,mname);
            mgrcon.Display();

        }
    }
}

