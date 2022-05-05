using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        //creating a object of Node class, called root which will save the first data coming from the user
        public Node<T> root;

       
        public void InsertDataInBST(T data)
        {
            
            Node<T> node = new Node<T>(data);

            //when there is no initial data and root is null, first value is added in root.
            if (root == null)
            {
                root = node;
            }
            else
            {
                //current position node is defined which have the value of root element.
                Node<T> currentPosition = root;
                //loop is instatiated to add value in binary search tree
                while (true)
                {
                    Node<T> parent = currentPosition;
                    
                    if (currentPosition.data.CompareTo(data) > 0)
                    {
                        currentPosition = currentPosition.left;
                        
                        if (currentPosition == null)
                        {
                            parent.left = node;
                            break;
                        }
                    }
                    else
                    {
                        
                        currentPosition = currentPosition.right;
                        if (currentPosition == null)
                        {
                            parent.right = node;
                            break;
                        }
                    }
                }
            }
        }
      
        public void DisplayDatainBST()
        {
           
            Node<T> parent = root;
           
            if (root.left != null)
            {
                parent = root;
                root = root.left;
                DisplayDatainBST();
            }
            Console.WriteLine("Data in sorted manner from :\t" + parent.data);
           
            if (root.right != null)
            {
                root = root.right;
                DisplayDatainBST();
            }
        }

    }
}