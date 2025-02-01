using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensinMethods
{
    static class ExtensionMethodCls
    {
        public static string IsEvenOrOdd(this int nmbr)
        {
            return nmbr % 2 == 0 ? "Even" : "Odd";//ternary operator condition ? true:false
        }
    }
}
