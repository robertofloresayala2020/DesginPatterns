using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorList.Interface
{

    //Define una interfaz que declare los métodos necesarios para recorrer la colección.
    public interface IIterator<T>
    {

         T Current { get; } 
        bool MoveNext();
        void Reset();
    }
}
