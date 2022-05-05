using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    
    class Node<T>
    {
        public T data;
        public Node<T> left;
        public Node<T> right;

       
        public Node(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }

    }
}