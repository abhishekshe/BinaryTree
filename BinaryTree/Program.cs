using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");

            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InsertDataInBST(70);
            binarySearchTree.InsertDataInBST(30);
            binarySearchTree.InsertDataInBST(56);
          

            binarySearchTree.DisplayDatainBST();
        }
    }
}