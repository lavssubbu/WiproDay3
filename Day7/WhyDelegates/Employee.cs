using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyDelegatesDemo
{
    public delegate bool DelPromote(Employee emp);
    public class Employee
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public int experienceinyears { get; set; }
        public decimal salary {  get; set; }

        public static void PromoteEMployee(List<Employee> lstemps, DelPromote isPromotable)
        {
            foreach (Employee emp in lstemps)
            {
                if (isPromotable(emp))//invoke target method,isPromote
                {
                    Console.WriteLine(emp.Name + " is Promoted");
                }
            }
        }
    }
}
