using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingcon
{
    //User defined exception
    internal class AgeException :Exception
    {
        public AgeException(string errmsg) :base(errmsg) 
        { }
    }
   
}
