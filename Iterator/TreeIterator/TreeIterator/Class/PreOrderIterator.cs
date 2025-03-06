using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeIterator.Interface;
using TreeIterator.Model;

namespace TreeIterator.Class
{
    public class PreOrderIterator<T> : IIterator<T>
    {

        private readonly TreeNode<T> _root;
        private Stack<TreeNode<T>> _stack;
        private TreeNode<T> _current;

        public PreOrderIterator(TreeNode<T> root)
        {

            _root = root;
            _stack = new Stack<TreeNode<T>>();
            Reset();

        }

        public T Current => _current.Value;

        public bool MoveNext()
        {
            if (_stack.Count == 0)
            {
                return false;
            }
            _current = _stack.Pop();
            if (_current.Right != null)
                _stack.Push(_current.Right);
            if (_current.Left != null)
                _stack.Push(_current.Left);
            return true;
        }

        public void Reset()
        {
            _stack.Clear();
            if (_root != null)
            {
                _stack.Push(_root);
            }
        }


    }


}
