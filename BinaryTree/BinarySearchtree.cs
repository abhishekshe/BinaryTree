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

  
        public void InsertDataInBST(T data)
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

    }
}