using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionConcept
{
    internal class Employee
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }

            public Employee()
            {
                Console.WriteLine("Default constructor");
            }
            public Employee(int ID, string Name, string Address)
            {
                this.Id = ID;
                this.Name = Name;
                this.Address = Address;
            }

            public void PrintID()
            {
                Console.WriteLine("Display" + Id);
            }

            public void PrintName()
            {
                Console.WriteLine("Name" + Name);
            }

        
    }
}
