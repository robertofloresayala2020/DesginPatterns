using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeIterator.Interface;
using TreeIterator.Model;
using System.Collections.Generic;

namespace TreeIterator.Class
{
    public class InOrderIterator<T> : IIterator<T>
    {

        private readonly TreeNode<T> _root;
        private Stack<TreeNode<T>> _stack;
        private TreeNode<T> _current;



        public InOrderIterator(TreeNode<T> root)
        {
            _root = root;
            _stack = new Stack<TreeNode<T>>();
            Reset();


        }


        public T Current
        {
            get
            {
                if (_current == null)
                    throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
                return _current.Value;
            }
        }

        public bool MoveNext()
        {
            while (_current!= null ||  _stack.Count>0)
            {
                while (_current != null)
                {   
                    _stack.Push(_current);
                    _current = _current.Left;
                }


                if (_stack.Count > 0)
                {
                    _current = _stack.Pop();
                    var result = _current;
                    _current = _current.Right;
                    return true;
                }


            }

            _current = null;
            return false;
        }

        public void Reset()
        {
            _current = _root;
            _stack.Clear();
        }
    }
}
