using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
          
            binarySearchTree.InsertDataInBST(23);
            binarySearchTree.InsertDataInBST(344);
            binarySearchTree.InsertDataInBST(43);
            binarySearchTree.InsertDataInBST(266);
            
            Node<int> head = binarySearchTree.InsertDataInBST(232);

            
            binarySearchTree.DisplayDatainBST();
        
            binarySearchTree.CountOfNodes();
             
            binarySearchTree.SearchInBST(head, 232);
        }
    }
}