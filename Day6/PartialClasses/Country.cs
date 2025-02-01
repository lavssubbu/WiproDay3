using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassdemo
{
    partial class  Country
    {
        public static string CountryNm = "India";

        public void CountryMethod()
        {
            Console.WriteLine("Country is"+CountryNm);
        }
    }
    partial class Country
    {
        public static string ParentCountryNm = "India";

        public void ParentCountryMethod()
        {
            Console.WriteLine("Country is" + CountryNm);
        }
    }


}
