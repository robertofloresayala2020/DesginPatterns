using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeIterator.Interface;
using TreeIterator.Model;

namespace TreeIterator.Class
{
    public class LevelOrderIterator<T> : IIterator<T>
    {

        private readonly TreeNode<T> _root;
        private Queue<TreeNode<T>> _queue;
        private TreeNode<T> _current;


        public LevelOrderIterator(TreeNode<T> root)
        {
            _root = root;
            _queue = new Queue<TreeNode<T>>();
            Reset();
        }

        public T Current => _current.Value;


        public bool MoveNext()
        {

            if (_queue.Count == 0)
                return false;

            _current = _queue.Dequeue();

            if (_current.Left != null)
                _queue.Enqueue(_current.Left);
            if (_current.Right != null)
                _queue.Enqueue(_current.Right);

            return true;

        }

        public void Reset()
        {
            _queue.Clear();
            if (_root != null)
                _queue.Enqueue(_root);
        }

    }
}
