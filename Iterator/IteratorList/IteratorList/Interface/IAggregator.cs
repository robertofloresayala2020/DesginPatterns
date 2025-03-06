using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IteratorList.Interface
{
    public interface IAggregator <T>
    {
            

            IteratorList.Interface.IIterator<T> CreateIterator();
    }
}
