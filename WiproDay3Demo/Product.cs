using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay3Demo
{
   class Product
    {
       int Proid; //class members
       string ProName; //class members

        public Product(int id,string name)
        {
            Proid = id;
            ProName = name;
        }

        //define a method
        private void SampleMthd()
        {
            Console.WriteLine("Private Method");
        }

        public void PublicMthd()
        {
            Console.WriteLine("Public Method"+Proid+" "+ProName); 
        }
    }
}
