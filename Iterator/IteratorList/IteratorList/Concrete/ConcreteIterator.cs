using IteratorList.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorList.Concrete
{
    public class ConcreteIterator<T> : IIterator<T>
    {


        private readonly T[] _collection;
        private int _currentIndex = -1;


        public ConcreteIterator(T[] collection)
        {
            _collection = collection;
        }


        public T Current => _collection[_currentIndex];


        public bool MoveNext()
        {
            if (_currentIndex + 1 < _collection.Length)
            { _currentIndex++;
                return true;
            }

            return false;
        
        }


        public  void Reset ()
        {
            _currentIndex = -1;
        }   
    }


}
