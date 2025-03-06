using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorList.Concrete;
using IteratorList.Interface;

namespace IteratorList.Agregator
{
    public class ConcreteAggregate<T> : IAggregator<T>
    {

        private readonly T[] _items;
        public ConcreteAggregate(T[] items)
        {
            _items = items;
        }
        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(_items);
        }
    }
}
