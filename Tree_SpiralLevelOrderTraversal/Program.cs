using System;

namespace Tree_SpiralLevelOrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree binaryTree = new Tree();
            binaryTree.root = new Node(1);
            binaryTree.root.left = new Node(2);
            binaryTree.root.right = new Node(3);
            binaryTree.root.left.left = new Node(4);
            binaryTree.root.left.right = new Node(5);
            binaryTree.root.right.left = new Node(7);
            binaryTree.root.right.right = new Node(8);

            binaryTree.horizontalTraversal(binaryTree.root);

            Console.ReadLine();
        }
    }
}
