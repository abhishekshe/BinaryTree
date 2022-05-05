using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    
    class BinarySearchTree<T> where T : IComparable
    {
        
        public Node<T> root;
        int leftNodeCount = 0;
        int rightNodeCount = 0;

        
        public Node<T> InsertDataInBST(T data)
        {
            
            
            Node<T> node = new Node<T>(data);

            
            if (root == null)
            {
                root = node;
            }
            else
            {
                
                Node<T> currentPosition = root;
                
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
            return root;
        }
        
        public void DisplayDatainBST()
        {
            
            Node<T> parent = root;
          
            if (root.left != null)
            {
                leftNodeCount++;
                parent = root;
                root = root.left;
                DisplayDatainBST();
            }
            Console.WriteLine("Data in sorted manner from :\t" + parent.data);
          
            if (root.right != null)
            {
                rightNodeCount++;
                root = root.right;
                DisplayDatainBST();
            }
        }
        
        public void CountOfNodes()
        {
            
            Console.WriteLine("Count for Left nodes are\t" + leftNodeCount);
            Console.WriteLine("Count for Right nodes are\t" + rightNodeCount);
        }
        
        public void SearchInBST(Node<T> root, T searchValue)
        {
            
            if (root == null)
            {
                Console.WriteLine("Value is not present in the binary search tree");
                return;
            }
            
            if (root.data.Equals(searchValue))
            {
                Console.WriteLine("searched value is there in the binary search tree");
                return;
            }
            
            if (root.data.CompareTo(searchValue) > 0)
            {
                root = root.left;
                SearchInBST(root, searchValue);
            }
            
            else
            {
                root = root.right;
                SearchInBST(root, searchValue);
            }
        }

    }
}