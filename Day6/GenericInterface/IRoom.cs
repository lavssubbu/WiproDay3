using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericINterface
{
    //Generic INterface - Generic Type <T>
    internal interface IRoom<T> //T is  a class 
    {
        IEnumerable<T> GetAll();
        void AddRoom(T item);
    }
}
