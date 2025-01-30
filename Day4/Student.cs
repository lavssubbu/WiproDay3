using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getsettermthdsample
{
    internal class Student
    {
        private int sid;

        public int Stuid
        {
            get
            {
                return sid;
            }
            set 
            {
                sid = value;
            }
        }
        private string sname;

        public string Name
        {
            get
            {
                return sname.ToUpper();
            }
            set
            {
                if(value == "Anu")
                {
                    Console.WriteLine("Anu not allowed");
                }
                else
                {
                    sname = value;
                }
             }
        }


        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if((value>5)&&(value>20))
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age not allowed");
                }
             
            }
        }

    }
}
