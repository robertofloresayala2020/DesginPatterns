﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeIterator.Model
{
    public class TreeNode <T>
    {

        public T Value { get; set; }
        public  TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
        }
    }
}
